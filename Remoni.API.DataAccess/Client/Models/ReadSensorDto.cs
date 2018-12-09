// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    public partial class ReadSensorDto
    {
        /// <summary>
        /// Initializes a new instance of the ReadSensorDto class.
        /// </summary>
        public ReadSensorDto() { }

        /// <summary>
        /// Initializes a new instance of the ReadSensorDto class.
        /// </summary>
        /// <param name="sensorType">Possible values include: 'AccessPoint',
        /// 'PowerMoniSpot', 'PowerMoniProC', 'FlowMoniSpot', 'FlowMoniPro',
        /// 'HeatMoniSpot', 'HeatMoniPro', 'TempMoniPro', 'RoomMoniSpot',
        /// 'RoomMoniPro', 'DataMoni'</param>
        /// <param name="calibrationType">Possible values include: 'Power',
        /// 'Current', 'AutoCurrent'</param>
        public ReadSensorDto(int sensorId, bool isConfigured, string sensorType, System.DateTimeOffset? dataLastRecorded = default(System.DateTimeOffset?), AccountNoRefsDto account = default(AccountNoRefsDto), System.Collections.Generic.IList<SensorActivitiesNoRefsDto> sensorActivities = default(System.Collections.Generic.IList<SensorActivitiesNoRefsDto>), System.Collections.Generic.IList<ReadSensorUnitValueDto> unitValues = default(System.Collections.Generic.IList<ReadSensorUnitValueDto>), double? calibrationConstant = default(double?), string calibrationType = default(string))
        {
            SensorId = sensorId;
            DataLastRecorded = dataLastRecorded;
            IsConfigured = isConfigured;
            SensorType = sensorType;
            Account = account;
            SensorActivities = sensorActivities;
            UnitValues = unitValues;
            CalibrationConstant = calibrationConstant;
            CalibrationType = calibrationType;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SensorId")]
        public int SensorId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DataLastRecorded")]
        public System.DateTimeOffset? DataLastRecorded { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "IsConfigured")]
        public bool IsConfigured { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'AccessPoint',
        /// 'PowerMoniSpot', 'PowerMoniProC', 'FlowMoniSpot', 'FlowMoniPro',
        /// 'HeatMoniSpot', 'HeatMoniPro', 'TempMoniPro', 'RoomMoniSpot',
        /// 'RoomMoniPro', 'DataMoni'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SensorType")]
        public string SensorType { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Account")]
        public AccountNoRefsDto Account { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SensorActivities")]
        public System.Collections.Generic.IList<SensorActivitiesNoRefsDto> SensorActivities { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "UnitValues")]
        public System.Collections.Generic.IList<ReadSensorUnitValueDto> UnitValues { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "CalibrationConstant")]
        public double? CalibrationConstant { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Power', 'Current',
        /// 'AutoCurrent'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "CalibrationType")]
        public string CalibrationType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SensorType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SensorType");
            }
            if (this.Account != null)
            {
                this.Account.Validate();
            }
            if (this.SensorActivities != null)
            {
                foreach (var element in this.SensorActivities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.UnitValues != null)
            {
                foreach (var element1 in this.UnitValues)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}