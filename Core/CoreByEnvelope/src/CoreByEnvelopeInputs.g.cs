// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace CoreByEnvelope
{
    public class CoreByEnvelopeInputs: S3Args
    {
		/// <summary>
		/// Percentage of highest square footage allocated to service core.
		/// </summary>
		[JsonProperty("Percentage Area")]
		public double PercentageArea {get;}

		/// <summary>
		/// Ratio of X to Y length of service core sides.
		/// </summary>
		[JsonProperty("Length to Width Ratio")]
		public double LengthToWidthRatio {get;}

		/// <summary>
		/// Minimum distance from service core perimeter to building perimeter.
		/// </summary>
		[JsonProperty("Minimum Perimeter Offset")]
		public double MinimumPerimeterOffset {get;}


        
        /// <summary>
        /// Construct a CoreByEnvelopeInputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public CoreByEnvelopeInputs() : base()
        {
			this.PercentageArea = 0.25;
			this.LengthToWidthRatio = 1.8;
			this.MinimumPerimeterOffset = 10;

        }


        /// <summary>
        /// Construct a CoreByEnvelopeInputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public CoreByEnvelopeInputs(double percentagearea, double lengthtowidthratio, double minimumperimeteroffset, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
			this.PercentageArea = percentagearea;
			this.LengthToWidthRatio = lengthtowidthratio;
			this.MinimumPerimeterOffset = minimumperimeteroffset;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}