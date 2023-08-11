using WicalWare.Components.ResultCs;

namespace WicalWare.Components.OgreCache.Abstractions;

public partial interface ICacheLayer
{
  string Name { get; }

  Result<IRetrieveResult, IRetrieveError> Retrieve(IRetrieveCommand retrieveCommand);

  Result<IEvictResult, IEvictError> Evict(IEvictCommand evictCommand);

  Result<IQueryResult, IQueryError> Query(IQueryCommand queryCommand);

  Result<IPurgeResult, IPurgeError> Purge(IPurgeCommand purgeCommand);
}
