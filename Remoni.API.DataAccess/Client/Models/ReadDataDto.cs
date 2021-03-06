// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    public partial class ReadDataDto
    {
        /// <summary>
        /// Initializes a new instance of the ReadDataDto class.
        /// </summary>
        public ReadDataDto() { }

        /// <summary>
        /// Initializes a new instance of the ReadDataDto class.
        /// </summary>
        /// <param name="dataType">Possible values include: 'current',
        /// 'current-a', 'current-b', 'current-c', 'current-d', 'current-01',
        /// 'current-02', 'current-03', 'current-04', 'current-05',
        /// 'current-06', 'current-07', 'current-08', 'current-09',
        /// 'current-10', 'current-11', 'current-12', 'current-13',
        /// 'current-14', 'current-15', 'voltage', 'voltage-01',
        /// 'voltage-02', 'voltage-03', 'voltage-04', 'voltage-05',
        /// 'voltage-06', 'voltage-07', 'voltage-08', 'voltage-09',
        /// 'voltage-10', 'voltage-11', 'voltage-12', 'voltage-13',
        /// 'voltage-14', 'voltage-15', 'grid-frequency', 'power-active',
        /// 'power-reactive', 'accumulated-power-active',
        /// 'accumulated-power-active-01', 'accumulated-power-active-02',
        /// 'accumulated-power-active-03', 'accumulated-power-active-04',
        /// 'accumulated-power-active-05', 'accumulated-power-active-06',
        /// 'accumulated-power-active-07', 'accumulated-power-active-08',
        /// 'accumulated-power-active-09', 'accumulated-power-active-10',
        /// 'accumulated-power-active-11', 'accumulated-power-active-12',
        /// 'accumulated-power-active-13', 'accumulated-power-active-14',
        /// 'accumulated-power-active-15', 'accumulated-power-reactive',
        /// 'sampleinterval', 'uncalibrated', 'average-temperature',
        /// 'external-temperature-1', 'internal-temperature',
        /// 'external-temperature-2', 'external-temperature-3',
        /// 'external-temperature-4', 'external-temperature-5',
        /// 'external-temperature-6', 'external-temperature-7', 'raw-1',
        /// 'raw-2', 'raw-3', 'raw-4', 'raw-5', 'raw-6', 'raw-7', 'raw-8',
        /// 'flow', 'heat', 'time-consumption'</param>
        /// <param name="aggregateType">Possible values include: 'Raw',
        /// 'Minutes5', 'Hour', 'Day'</param>
        public ReadDataDto(int unitId, int sensorId, string dataType, string aggregateType, System.DateTimeOffset timestamp, int? accountId = default(int?), double? value = default(double?), string baseProperty = default(string))
        {
            AccountId = accountId;
            UnitId = unitId;
            SensorId = sensorId;
            DataType = dataType;
            AggregateType = aggregateType;
            Timestamp = timestamp;
            Value = value;
            BaseProperty = baseProperty;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AccountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "UnitId")]
        public int UnitId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SensorId")]
        public int SensorId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'current', 'current-a',
        /// 'current-b', 'current-c', 'current-d', 'current-01',
        /// 'current-02', 'current-03', 'current-04', 'current-05',
        /// 'current-06', 'current-07', 'current-08', 'current-09',
        /// 'current-10', 'current-11', 'current-12', 'current-13',
        /// 'current-14', 'current-15', 'voltage', 'voltage-01',
        /// 'voltage-02', 'voltage-03', 'voltage-04', 'voltage-05',
        /// 'voltage-06', 'voltage-07', 'voltage-08', 'voltage-09',
        /// 'voltage-10', 'voltage-11', 'voltage-12', 'voltage-13',
        /// 'voltage-14', 'voltage-15', 'grid-frequency', 'power-active',
        /// 'power-reactive', 'accumulated-power-active',
        /// 'accumulated-power-active-01', 'accumulated-power-active-02',
        /// 'accumulated-power-active-03', 'accumulated-power-active-04',
        /// 'accumulated-power-active-05', 'accumulated-power-active-06',
        /// 'accumulated-power-active-07', 'accumulated-power-active-08',
        /// 'accumulated-power-active-09', 'accumulated-power-active-10',
        /// 'accumulated-power-active-11', 'accumulated-power-active-12',
        /// 'accumulated-power-active-13', 'accumulated-power-active-14',
        /// 'accumulated-power-active-15', 'accumulated-power-reactive',
        /// 'sampleinterval', 'uncalibrated', 'average-temperature',
        /// 'external-temperature-1', 'internal-temperature',
        /// 'external-temperature-2', 'external-temperature-3',
        /// 'external-temperature-4', 'external-temperature-5',
        /// 'external-temperature-6', 'external-temperature-7', 'raw-1',
        /// 'raw-2', 'raw-3', 'raw-4', 'raw-5', 'raw-6', 'raw-7', 'raw-8',
        /// 'flow', 'heat', 'time-consumption'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Raw', 'Minutes5', 'Hour',
        /// 'Day'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AggregateType")]
        public string AggregateType { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Timestamp")]
        public System.DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Value")]
        public double? Value { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Base")]
        public string BaseProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataType");
            }
            if (AggregateType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AggregateType");
            }
        }
    }
}
