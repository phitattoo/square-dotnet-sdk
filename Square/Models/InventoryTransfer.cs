using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class InventoryTransfer 
    {
        public InventoryTransfer(string id = null,
            string referenceId = null,
            string state = null,
            string fromLocationId = null,
            string toLocationId = null,
            string catalogObjectId = null,
            string catalogObjectType = null,
            string quantity = null,
            string occurredAt = null,
            string createdAt = null,
            Models.SourceApplication source = null,
            string employeeId = null)
        {
            Id = id;
            ReferenceId = referenceId;
            State = state;
            FromLocationId = fromLocationId;
            ToLocationId = toLocationId;
            CatalogObjectId = catalogObjectId;
            CatalogObjectType = catalogObjectType;
            Quantity = quantity;
            OccurredAt = occurredAt;
            CreatedAt = createdAt;
            Source = source;
            EmployeeId = employeeId;
        }

        /// <summary>
        /// A unique ID generated by Square for the
        /// `InventoryTransfer`.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; }

        /// <summary>
        /// An optional ID provided by the application to tie the
        /// `InventoryTransfer` to an external system.
        /// </summary>
        [JsonProperty("reference_id")]
        public string ReferenceId { get; }

        /// <summary>
        /// Indicates the state of a tracked item quantity in the lifecycle of goods.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; }

        /// <summary>
        /// The Square ID of the [Location](#type-location) where the related
        /// quantity of items were tracked before the transfer.
        /// </summary>
        [JsonProperty("from_location_id")]
        public string FromLocationId { get; }

        /// <summary>
        /// The Square ID of the [Location](#type-location) where the related
        /// quantity of items were tracked after the transfer.
        /// </summary>
        [JsonProperty("to_location_id")]
        public string ToLocationId { get; }

        /// <summary>
        /// The Square generated ID of the
        /// `CatalogObject` being tracked.
        /// </summary>
        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; }

        /// <summary>
        /// The `CatalogObjectType` of the
        /// `CatalogObject` being tracked.Tracking is only
        /// supported for the `ITEM_VARIATION` type.
        /// </summary>
        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; }

        /// <summary>
        /// The number of items affected by the transfer as a decimal string.
        /// Can support up to 5 digits after the decimal point.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; }

        /// <summary>
        /// A client-generated timestamp in RFC 3339 format that indicates when
        /// the transfer took place. For write actions, the `occurred_at` timestamp
        /// cannot be older than 24 hours or in the future relative to the time of the
        /// request.
        /// </summary>
        [JsonProperty("occurred_at")]
        public string OccurredAt { get; }

        /// <summary>
        /// A read-only timestamp in RFC 3339 format that indicates when Square
        /// received the transfer request.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; }

        /// <summary>
        /// Provides information about the application used to generate a change.
        /// </summary>
        [JsonProperty("source")]
        public Models.SourceApplication Source { get; }

        /// <summary>
        /// The Square ID of the [Employee](#type-employee) responsible for the
        /// inventory transfer.
        /// </summary>
        [JsonProperty("employee_id")]
        public string EmployeeId { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(Id)
                .ReferenceId(ReferenceId)
                .State(State)
                .FromLocationId(FromLocationId)
                .ToLocationId(ToLocationId)
                .CatalogObjectId(CatalogObjectId)
                .CatalogObjectType(CatalogObjectType)
                .Quantity(Quantity)
                .OccurredAt(OccurredAt)
                .CreatedAt(CreatedAt)
                .Source(Source)
                .EmployeeId(EmployeeId);
            return builder;
        }

        public class Builder
        {
            private string id;
            private string referenceId;
            private string state;
            private string fromLocationId;
            private string toLocationId;
            private string catalogObjectId;
            private string catalogObjectType;
            private string quantity;
            private string occurredAt;
            private string createdAt;
            private Models.SourceApplication source;
            private string employeeId;

            public Builder() { }
            public Builder Id(string value)
            {
                id = value;
                return this;
            }

            public Builder ReferenceId(string value)
            {
                referenceId = value;
                return this;
            }

            public Builder State(string value)
            {
                state = value;
                return this;
            }

            public Builder FromLocationId(string value)
            {
                fromLocationId = value;
                return this;
            }

            public Builder ToLocationId(string value)
            {
                toLocationId = value;
                return this;
            }

            public Builder CatalogObjectId(string value)
            {
                catalogObjectId = value;
                return this;
            }

            public Builder CatalogObjectType(string value)
            {
                catalogObjectType = value;
                return this;
            }

            public Builder Quantity(string value)
            {
                quantity = value;
                return this;
            }

            public Builder OccurredAt(string value)
            {
                occurredAt = value;
                return this;
            }

            public Builder CreatedAt(string value)
            {
                createdAt = value;
                return this;
            }

            public Builder Source(Models.SourceApplication value)
            {
                source = value;
                return this;
            }

            public Builder EmployeeId(string value)
            {
                employeeId = value;
                return this;
            }

            public InventoryTransfer Build()
            {
                return new InventoryTransfer(id,
                    referenceId,
                    state,
                    fromLocationId,
                    toLocationId,
                    catalogObjectId,
                    catalogObjectType,
                    quantity,
                    occurredAt,
                    createdAt,
                    source,
                    employeeId);
            }
        }
    }
}