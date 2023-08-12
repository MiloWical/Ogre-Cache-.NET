// Copyright (c) Milo Wical. All rights reserved.
using WicalWare.Components.ResultCs;

namespace WicalWare.Components.OgreCache.Abstractions;

/// <summary>
/// Represents a command used to delete ALL values from the cache.
/// </summary>
public interface IPurgeCommand
{
  /// <summary>
  /// Gets a value indicating whether the purge should cascade through
  /// the cache layers above the target.
  /// </summary>
  /// <value>A flag whether the purge should cascade or not.</value>
  bool Cascade { get; }

  /// <summary>
  /// Gets the name of the target cache layer to purge.
  /// </summary>
  /// <value>The name of the target cache layer is Option.Some if
  /// it's set, otherwise Option.None, meaning it can apply to any/all
  /// layers.</value>
  Option<string> TargetCacheName { get; }
}
