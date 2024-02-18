using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System;
using NAudio.Wave.SampleProviders;

namespace Tremblr.TremblrControl
{


    using NAudio.Wave;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using NAudio.Wave;
    using System;

    public class AudioGenerator
    {
        private WaveOutEvent outputDevice;
        private WaveFormat waveFormat;
        private SignalGenerator signalGenerator;
        private double audioLevel;
        private double frequency;

        public AudioGenerator(int deviceNumber = 0, int sampleRate = 44100, int channels = 2)
        {
            waveFormat = new WaveFormat(sampleRate, channels);

            // Get available output devices (sound cards)
            List<WaveOutCapabilities> outputDevices = GetOutputDevices();

            // Check if the specified device number is valid
            if (deviceNumber < 0 || deviceNumber >= outputDevices.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(deviceNumber), "Invalid device number.");
            }

            // Initialize output device with specified device number
            outputDevice = new WaveOutEvent()
            {
                DeviceNumber = deviceNumber
            };

            signalGenerator = new SignalGenerator()
            {
                Gain = 0.5, // Adjust amplitude here (0.0 to 1.0)
                Frequency = 440, // Default frequency is A4 (440 Hz)
                Type = SignalGeneratorType.Sin // Sine wave, but you can change to other types
            };

            outputDevice.Init(signalGenerator);
        }

        public void Play()
        {
            outputDevice.Play();
        }

        public void Stop()
        {
            outputDevice.Stop();
        }

        public void SetFrequency(double frequency2)
        {
            frequency = frequency2;
            signalGenerator.Frequency = frequency;
        }

        public void SetAmplitude(double amplitude)
        {
            audioLevel = amplitude;
            signalGenerator.Gain = amplitude;
        }

        async public Task Program1()
        {
            bool up = true;
            audioLevel = 0;
            while (true)
            {
                if (up)
                {
                    SetAmplitude(audioLevel+0.001);
                }
                else
                {
                    SetAmplitude(audioLevel - 0.001);
                }
                
                if (audioLevel >= 0.1)
                {
                    up = false;
                }
                else if(audioLevel <= 0.05)
                {
                    up = true;
                }
                //Console.WriteLine(audioLevel);
                await Task.Delay(100);
            }
        }
        async public Task Program2()
        {
            bool up = true;
            frequency = 2400;
            audioLevel = 0.8;
            //SetAmplitude(audioLevel);
            SetFrequency(frequency);
            SetAmplitude(audioLevel);
            
            while (true)
            {
                Play();
                await Task.Delay(500);
                Stop();
                await Task.Delay(5000);
            }
            
        }

        // Method to get a list of available output devices (sound cards)
        static private List<WaveOutCapabilities> GetOutputDevices()
        {
            List<WaveOutCapabilities> outputDevices = new List<WaveOutCapabilities>();
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                outputDevices.Add(WaveOut.GetCapabilities(i));
            }
            return outputDevices;
        }

        // Method to print the available output devices (sound cards)
        static public void PrintOutputDevices()
        {
            List<WaveOutCapabilities> outputDevices = GetOutputDevices();
            Console.WriteLine("Available output devices (sound cards):");
            for (int i = 0; i < outputDevices.Count; i++)
            {
                Console.WriteLine($"{i}: {outputDevices[i].ProductName}");
            }
        }


    }
}
