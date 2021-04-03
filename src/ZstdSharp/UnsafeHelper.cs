﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using static InlineIL.IL.Emit;
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

[module: SkipLocalsInit]

namespace ZstdSharp
{
    public static unsafe class UnsafeHelper
    {
        public static void* PoisonMemory(void* destination, int size)
        {
            memset(destination, 0xCC, size);
            return destination;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void* malloc(uint size)
        {
#if DEBUG
            return PoisonMemory((void*)Marshal.AllocHGlobal((int)size), (int)size);
#else
            return (void*) Marshal.AllocHGlobal((int) size);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void* malloc(ulong size)
        {
#if DEBUG
            return PoisonMemory((void*)Marshal.AllocHGlobal((int)size), (int)size);
#else
            return (void*)Marshal.AllocHGlobal((int)size);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void* calloc(ulong num, ulong size)
        {
            int total = (int)(num * size);
            var destination = (void*)Marshal.AllocHGlobal(total);
            //Unsafe.InitBlockUnaligned(destination, 0, (uint)total);
            //Ldloc(nameof(destination));
            memset(destination, 0, total);
            return destination;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void free(void* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void* memcpy(void* destination, void* source, ulong size)
        {
            //Unsafe.CopyBlockUnaligned(destination, source, (uint)size);
            Ldarg(nameof(destination));
            Ldarg(nameof(source));
            Ldarg(nameof(size));
            Unaligned(1);
            Cpblk();
            return destination;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void* memcpy(void* destination, void* source, uint size)
        {
            //Unsafe.CopyBlockUnaligned(destination, source, size);
            Ldarg(nameof(destination));
            Ldarg(nameof(source));
            Ldarg(nameof(size));
            Unaligned(1);
            Cpblk();
            return destination;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void* memcpy(void* destination, void* source, int size)
        {
            //Unsafe.CopyBlockUnaligned(destination, source, (uint)size);
            Ldarg(nameof(destination));
            Ldarg(nameof(source));
            Ldarg(nameof(size));
            Unaligned(1);
            Cpblk();
            return destination;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void memset(void* memPtr, int val, uint size)
        {
            //Unsafe.InitBlockUnaligned(memPtr, (byte)val, size);
            Ldarg(nameof(memPtr));
            Ldarg(nameof(val));
            Ldarg(nameof(size));
            Unaligned(1);
            Initblk();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void memset(void* memPtr, int val, int size)
        {
            //Unsafe.InitBlockUnaligned(memPtr, (byte)val, (uint)size);
            Ldarg(nameof(memPtr));
            Ldarg(nameof(val));
            Ldarg(nameof(size));
            Unaligned(1);
            Initblk();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void memset(void* memPtr, int val, ulong size)
        {
            //Unsafe.InitBlockUnaligned(memPtr, (byte)val, (uint)size);
            Ldarg(nameof(memPtr));
            Ldarg(nameof(val));
            Ldarg(nameof(size));
            Unaligned(1);
            Initblk();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T* GetArrayPointer<T>(T[] array) where T : unmanaged
        {
            var size = (uint)(sizeof(T) * array.Length);
            var destination = (T*)malloc(size);
            fixed (void* source = &array[0])
                memcpy(destination, source, size);

            return destination;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte* GetStringPointer(string str) => 
            StringHelper.GetPointer(str);

        [Conditional("DEBUG")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void assert(bool condition, string message = null)
        {
            if (!condition)
                throw new ArgumentException(message ?? "assert failed");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void memmove(void* destination, void* source, ulong size)
        {
            Buffer.MemoryCopy(source, destination, size, size);
        }

        public static bool IsBmi2Supported => System.Runtime.Intrinsics.X86.Bmi2.IsSupported;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void Prefetch0(void* p)
        {
            //Sse.Prefetch0(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [InlineMethod.Inline]
        public static void Prefetch1(void* p)
        {
            //Sse.Prefetch1(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int memcmp(void* buf1, void* buf2, ulong size)
        {
            var p1 = (byte*)buf1;
            var p2 = (byte*)buf2;

            while (size > 0)
            {
                var diff = *p1++ - *p2++;
                if (diff != 0)
                {
                    return diff;
                }
                size--;
            }
            return 0;
        }

        public static class StringHelper
        {
            public class PinnedBuffer : IDisposable
            {
                public GCHandle Handle { get; }
                public byte[] Data { get; private set; }

                public IntPtr Ptr => Handle.AddrOfPinnedObject();

                public PinnedBuffer(byte[] bytes)
                {
                    Data = bytes;
                    Handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                }

                public void Dispose()
                {
                    Dispose(true);
                    GC.SuppressFinalize(this);
                }

                protected virtual void Dispose(bool disposing)
                {
                    if (disposing)
                    {
                        Handle.Free();
                        Data = null;
                    }
                }
            }

            private static readonly Dictionary<string, PinnedBuffer> PinnedBuffers = new();

            public static sbyte* GetPointer(string str)
            {
                if (!PinnedBuffers.TryGetValue(str, out var pinnedBuffer))
                {
                    var byteLength = Encoding.UTF8.GetByteCount(str);
                    var bytes = new byte[byteLength + 1];
                    Encoding.UTF8.GetBytes(str, 0, str.Length, bytes, 0);
                    pinnedBuffer = new PinnedBuffer(bytes);
                    PinnedBuffers[str] = pinnedBuffer;
                }

                return (sbyte*) pinnedBuffer.Ptr;
            }
        }
    }
}
