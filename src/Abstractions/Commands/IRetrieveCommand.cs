// Copyright (c) Milo Wical. All rights reserved.

using WicalWare.Components.ResultCs;

namespace WicalWare.Components.OgreCache.Abstractions;

/// <summary>
/// Represents a command used to retrieve (get) a value from the cache.
/// </summary>
/// <typeparam name="TOutput">The expected type of the retrieved value.</typeparam>
public interface IRetrieveCommand<TOutput>
{
  /// <summary>
  /// Gets the command search key.
  /// </summary>
  /// <value>The key to use to search the cache.</value>
  string Key { get; }

  /// <summary>
  /// Gets an <seealso cref="Option{TSome}"/> that contains
  /// a default value for the lookup if the key isn't found.
  /// </summary>
  /// <value>Option.Some(T) if set, otherwise Option.None.</value>
  Option<TOutput> Default { get; }
}
