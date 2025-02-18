using System;
using System.IO;
using NAudio.Wave;

Namespace AudioProcessing
{
   public class AudioEditor
   {
       public void AdjustVolume(string inputFilePath, string outputFilePath, float volume)
       {
           using (var reader = new AudioFileReader(inputFilePath))
           {
               using (var volumeStream = new VolumeSampleProvider(reader.ToSampleProvider()))
               {
                   volumeStream.Volume = volume;

                   WaveFileWriter.CreateWaveFile16(outputFilePath, volumeStream);
               }
           }
       }

       public void ApplyFade(string inputFilePath, string outputFilePath, TimeSpan fadeDuration)
       {
           // フェード処理の実装 (必要なロジックを追加)
       }
   }

}