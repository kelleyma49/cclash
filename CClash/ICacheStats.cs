﻿using System;
namespace CClash
{
    public interface ICacheStats : IDisposable
    {
        long CacheHits { get; set; }
        long CacheMisses { get; set; }
        long CacheObjects { get; set; }
        long CacheSize { get; set; }
        long CacheUnsupported { get; set; }
        void LockStatsCall(Action x);
        long MSecLost { get; set; }
        bool OmitLocks { get; set; }
        long SlowHitCount { get; set; }

        void Commit();
    }
}
