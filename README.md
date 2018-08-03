# SanPellgrino
a collection of helper extension methods

* [ForEach](#foreach)

### ForEach

foreach in linq-style

```csharp
await ownEvents
    .Union(overridableEvents)
    .Union(allRestaurantEvents)
    .ForEachAsync(async e => await _mediator.Send(new ExcludeRestaurantsFromEventCommand(Tenant, e.EventId, RestaurantId.Id.ToString(),
        requesterUserRole, requester))
    );

```
