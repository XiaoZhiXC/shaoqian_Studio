﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetStudioUtility
{
    public enum VertexComponent : uint
    {
        None = 0xFFFFFFFF,
        Vertex = 0x0,
        Color = 0x1,
        Normal = 0x2,
        TexCoord = 0x3,
        TexCoord0 = 0x4,
        TexCoord1 = 0x5,
        TexCoord2 = 0x6,
        TexCoord3 = 0x7,
        TexCoord4 = 0x8,
        TexCoord5 = 0x9,
        TexCoord6 = 0xA,
        TexCoord7 = 0xB,
        Attrib0 = 0xC,
        Attrib1 = 0xD,
        Attrib2 = 0xE,
        Attrib3 = 0xF,
        Attrib4 = 0x10,
        Attrib5 = 0x11,
        Attrib6 = 0x12,
        Attrib7 = 0x13,
        Attrib8 = 0x14,
        Attrib9 = 0x15,
        Attrib10 = 0x16,
        Attrib11 = 0x17,
        Attrib12 = 0x18,
        Attrib13 = 0x19,
        Attrib14 = 0x1A,
        Attrib15 = 0x1B,
        Count = 0x1C,
    }

    public sealed class ShaderBindChannelJ
    {
        public ShaderBindChannelJ() { }

        public ShaderBindChannelJ(uint source, VertexComponent target)
        {
            Source = source;
            Target = target;
        }

        /// <summary>
        /// ShaderChannel enum
        /// </summary>
        public uint Source { get; set; }
        public VertexComponent Target { get; set; }
    }
}
