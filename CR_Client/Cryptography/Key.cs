﻿using CR_Client.Library.Sodium;

namespace CR_Client.Packets.Cryptography
{
    internal class Key
    {
        public static KeyPairCR Crypto { get => new KeyPairCR((byte[])PublicKey.Clone(), (byte[])PrivateKey.Clone()); }

        internal static readonly byte[] PrivateKey =
        {
            0x18, 0x91, 0xD4, 0x01, 0xFA, 0xDB, 0x51, 0xD2, 0x5D, 0x3A, 0x91, 0x74,
            0xD4, 0x72, 0xA9, 0xF6, 0x91, 0xA4, 0x5B, 0x97, 0x42, 0x85, 0xD4, 0x77,
            0x29, 0xC4, 0x5C, 0x65, 0x38, 0x07, 0x0D, 0x85
        };

        internal static readonly byte[] PublicKey =
        {
            0x72, 0xF1, 0xA4, 0xA4, 0xC4, 0x8E, 0x44, 0xDA, 0x0C, 0x42, 0x31, 0x0F,
            0x80, 0x0E, 0x96, 0x62, 0x4E, 0x6D, 0xC6, 0xA6, 0x41, 0xA9, 0xD4, 0x1C,
            0x3B, 0x50, 0x39, 0xD8, 0xDF, 0xAD, 0xC2, 0x7E
        };

        public static readonly byte[] NonceKey =
        {
            0x72, 0xA4, 0x42, 0x18, 0xC4, 0x8E, 0x29, 0x0C, 0x62, 0x31, 0x62, 0x80,
            0xD4, 0xF6, 0x62, 0x6D, 0xA6, 0x42, 0xF1, 0x29, 0xA4, 0xA4, 0x00, 0x8E
        };
    }
}
