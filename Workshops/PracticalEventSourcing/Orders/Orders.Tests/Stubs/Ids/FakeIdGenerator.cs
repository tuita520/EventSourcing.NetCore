// using System;
// using Core.Aggregates;
// using Core.Ids;
//
// namespace Orders.Tests.Stubs.Ids
// {
//     public class FakeIdGenerator : IIdGenerator
//     {
//         public Guid? LastGeneratedId { get; private set; }
//         public Guid New() => (LastGeneratedId = Guid.NewGuid()).Value;
//     }
// }
