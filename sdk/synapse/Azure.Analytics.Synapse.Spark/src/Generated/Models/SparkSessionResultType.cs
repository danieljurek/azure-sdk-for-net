// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkSessionResultType. </summary>
    public readonly partial struct SparkSessionResultType : IEquatable<SparkSessionResultType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SparkSessionResultType"/> values are the same. </summary>
        public SparkSessionResultType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UncertainValue = "Uncertain";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";

        /// <summary> Uncertain. </summary>
        public static SparkSessionResultType Uncertain { get; } = new SparkSessionResultType(UncertainValue);
        /// <summary> Succeeded. </summary>
        public static SparkSessionResultType Succeeded { get; } = new SparkSessionResultType(SucceededValue);
        /// <summary> Failed. </summary>
        public static SparkSessionResultType Failed { get; } = new SparkSessionResultType(FailedValue);
        /// <summary> Cancelled. </summary>
        public static SparkSessionResultType Cancelled { get; } = new SparkSessionResultType(CancelledValue);
        /// <summary> Determines if two <see cref="SparkSessionResultType"/> values are the same. </summary>
        public static bool operator ==(SparkSessionResultType left, SparkSessionResultType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkSessionResultType"/> values are not the same. </summary>
        public static bool operator !=(SparkSessionResultType left, SparkSessionResultType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkSessionResultType"/>. </summary>
        public static implicit operator SparkSessionResultType(string value) => new SparkSessionResultType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkSessionResultType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkSessionResultType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
