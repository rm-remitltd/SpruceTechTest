using System;
using System.Linq;

namespace LDMSTechnicalTest.TestHelpers
{
    public static class RandomStringBuilder
    {
        private const string LetterPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly Random Random = new Random();

        public static string GenerateRandomAlphabeticString(int length)
        {
            var chars = Enumerable.Range(0, length).Select(x => LetterPool[Random.Next(0, LetterPool.Length)]);

            return new string(chars.ToArray());
        }

        public static string GenerateName() => GenerateRandomAlphabeticString(10) + " " + GenerateRandomAlphabeticString(20);
    }
}