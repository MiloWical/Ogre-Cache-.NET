// Copyright (c) Milo Wical. All rights reserved.

namespace WicalWare.Components.OgreCache.Abstractions;

/// <summary>
/// Defines the type of the query command.
/// </summary>
public enum QueryTarget
{
  /// <summary>
  /// Tells the <c>IQueryCommand</c> to query values (default).
  /// </summary>
  Value,

  /// <summary>
  /// Tells the <c>IQueryCommand</c> to query keys.
  /// </summary>
  Key,
}
