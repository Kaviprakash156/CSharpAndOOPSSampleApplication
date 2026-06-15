using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops.Concepts
{
    internal class Interfaces
    {
        static void Main()
        {
            Console.WriteLine("=== Basic Interface ===");

            IPlayable player = new MediaCenter();
            player.Play();


            Console.WriteLine("\n=== Multiple Interface Implementation ===");

            MediaCenter media = new MediaCenter();
            media.Record();


            Console.WriteLine("\n=== Interface Inheritance ===");

            IStreamable streamer = new MediaCenter();
            streamer.Play();
            streamer.Stream();


            Console.WriteLine("\n=== Explicit Interface Implementation ===");

            ILocalStorage local = new StorageManager();
            local.Save();

            ICloudStorage cloud = new StorageManager();
            cloud.Save();


            Console.WriteLine("\n=== Interface Polymorphism ===");

            IPlayable polymorphicPlayer = new MediaCenter();
            polymorphicPlayer.Play();


            Console.WriteLine("\n=== Default Interface Method ===");

            IShareable shareable = new MediaCenter();
            shareable.Share();
        }
    }
    // 1. Basic Interface
    interface IPlayable
    {
        void Play();
    }

    // 2. Multiple Interfaces
    interface IRecordable
    {
        void Record();
    }

    // 3. Interface Inheritance
    interface IStreamable : IPlayable
    {
        void Stream();
    }

    // 6. Default Interface Method (C# 8+)
    interface IShareable
    {
        void Share()
        {
            Console.WriteLine("Content shared successfully.");
        }
    }

    // Explicit Interface Example
    interface ILocalStorage
    {
        void Save();
    }

    interface ICloudStorage
    {
        void Save();
    }

    // Implementing Multiple Interfaces
    class MediaCenter : IStreamable, IRecordable, IShareable
    {
        // Basic Interface Implementation
        public void Play()
        {
            Console.WriteLine("Playing media.");
        }

        // Multiple Interface Implementation
        public void Record()
        {
            Console.WriteLine("Recording media.");
        }

        // Interface Inheritance
        public void Stream()
        {
            Console.WriteLine("Streaming media.");
        }
    }

    // Explicit Interface Implementation
    class StorageManager : ILocalStorage, ICloudStorage
    {
        void ILocalStorage.Save()
        {
            Console.WriteLine("Saved to Local Storage.");
        }

        void ICloudStorage.Save()
        {
            Console.WriteLine("Saved to Cloud Storage.");
        }
    }
}
