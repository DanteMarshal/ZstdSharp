using System;

namespace ZstdSharp
{
    public unsafe partial struct ZSTD_compressedBlockState_t
    {
        public ZSTD_entropyCTables_t entropy;

        public fixed uint rep[3];
    }
}
