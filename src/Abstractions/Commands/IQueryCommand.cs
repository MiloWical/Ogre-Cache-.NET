// Copyright (c) Milo Wical. All rights reserved.
using WicalWare.Components.ResultCs;

namespace WicalWare.Components.OgreCache.Abstractions;

/// <summary>
/// Represents a command used to query keys or values in the cache.
/// </summary>
/// <typeparam name="TOutput">The expected type of the retrieved value.</typeparam>
public interface IQueryCommand<TOutput>
{
  /// <summary>
  /// Gets the target of the query.
  /// </summary>
  /// <value>The <c>QueryTarget</c> that the command should search.</value>
  QueryTarget QueryTarget { get; }

  /// <summary>
  /// Gets the command key search pattern.
  /// </summary>
  /// <value>The key pattern to use to search the cache. If Option.Some,
  /// then the key pattern is used.</value>
  Option<string> KeyPattern { get; }

  /// <summary>
  /// Gets the command value search pattern.
  /// </summary>
  /// <value>The value pattern to use to search the cache. If Option.Some,
  /// then the value pattern is used.</value>
  Option<string> ValuePattern { get; }

  /// <summary>
  /// Gets an <seealso cref="Option{TSome}"/> that contains
  /// a default value for the lookup if the key isn't found.
  /// </summary>
  /// <value>Option.Some(T) if set, otherwise Option.None.</value>
  Option<TOutput> Default { get; }
}
