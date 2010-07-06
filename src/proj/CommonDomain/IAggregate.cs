namespace CommonDomain
{
	using System;

	public interface IAggregate : IApplyEvents, IProduceEvents, IProduceSnapshots
	{
		Guid Id { get; }
	}
}