using System;
using System.Threading.Tasks;
using System.IO;
using NAudio.Wave;
using System.Threading;
using NAudio.Wave.SampleProviders;
using System.Windows.Forms;

namespace AudioRecorder
{
    class Record
    {
        private bool isRecording = false;
        private WasapiLoopbackCapture capture;
        private WaveOutEvent wo = new WaveOutEvent();

        public Record()
        {
            capture = new WasapiLoopbackCapture();
        }

        public bool setup(string folderPath, string fileName, bool isRecordSilence)
        {
            if (isRecording)
            {
                throw new InvalidOperationException("Already in Recording!");
            }
            else
            {
                var outputFolder = Path.Combine(folderPath);
                var outputFilePath = Path.Combine(outputFolder, fileName + ".wav");
                WaveFileWriter writer = null;
                try
                {
                    writer = new WaveFileWriter(outputFilePath, capture.WaveFormat);
                }catch(DirectoryNotFoundException e)
                {
                    MessageBox.Show("Folder Path was invalid.");
                    return false;
                }

                capture.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                };

                capture.RecordingStopped += (s, a) =>
                {
                    writer.Dispose();
                    writer = null;
                    capture.Dispose();
                };

                Task task_record = Task.Run(() => {
                    StartRecording();
                });
                isRecording = true;

                if (isRecordSilence)
                {
                    Task task_silence = Task.Run(() => {
                        StartSine();
                    });
                }
                return true;
            }
        }

        private void StartSine()
        {
            var sinesetup = new SignalGenerator()
            {
                Gain = 0.0,
                Frequency = 440,
                Type = SignalGeneratorType.Sin
            };

            wo.Init(sinesetup);
            wo.Play();
            while (wo.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(500);
            }
        }

        private void QuitSine()
        {
            wo.Stop();
        }

        public void QuitRecording(bool isRecordSilence)
        {
            isRecording = false;
            capture.StopRecording();
            if (isRecordSilence)
            {
                QuitSine();
            }
        }

        private void StartRecording()
        {
            capture.StartRecording();
            while (capture.CaptureState != NAudio.CoreAudioApi.CaptureState.Stopped)
            {
                Thread.Sleep(500);
            }
        }
    }

}
