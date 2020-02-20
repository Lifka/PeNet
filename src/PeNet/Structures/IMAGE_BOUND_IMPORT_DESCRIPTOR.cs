﻿using PeNet.Utilities;

namespace PeNet.Structures
{
    /// <summary>
    /// Bound import descriptor.
    /// </summary>
    public class IMAGE_BOUND_IMPORT_DESCRIPTOR : AbstractStructure
    {
        /// <summary>
        /// Create new bound import descriptor structure.
        /// </summary>
        /// <param name="buff">PE file as byte buffer.</param>
        /// <param name="offset">Offset of bound import descriptor in the buffer.</param>
        public IMAGE_BOUND_IMPORT_DESCRIPTOR(byte[] buff, uint offset) 
            : base(buff, offset)
        {
        }

        /// <summary>
        /// Time date stamp.
        /// </summary>
        public uint TimeDateStamp
        {
            get => PeFile.ReadUInt(Offset + 0);
            set => PeFile.WriteUInt(Offset + 0, value);
        }

        /// <summary>
        /// Offset module name.
        /// </summary>
        public ushort OffsetModuleName
        {
            get => PeFile.ReadUShort(Offset + 4);
            set => PeFile.WriteUShort(Offset + 2, value);
        }

        /// <summary>
        /// Number of module forwarder references.
        /// </summary>
        public ushort NumberOfModuleForwarderRefs
        {
            get => PeFile.ReadUShort(Offset + 6);
            set => PeFile.WriteUShort(Offset + 4, value);
        }
    }
}