﻿using System.Linq;
using FluentAssertions;
using Nop.Core.Infrastructure;
using Nop.Tests;
using NUnit.Framework;

namespace Nop.Core.Tests.Infrastructure
{
    [TestFixture]
    public class TypeFinderTests : BaseNopTest
    {
        [Test]
        public void TypeFinderBenchmarkFindings()
        {
            var finder = GetService<ITypeFinder>();
            var type = finder.FindClassesOfType<ISomeInterface>().ToList();
            type.Count.Should().Be(1);
            typeof(ISomeInterface).IsAssignableFrom(type.FirstOrDefault()).Should().BeTrue();
        }

        public interface ISomeInterface
        {
        }

        public class SomeClass : ISomeInterface
        {
        }
    }
}
