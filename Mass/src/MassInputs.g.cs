// This code was generated by Hypar.
// Edits to this code will be overwritten the next time code generation occurs.
// DO NOT EDIT THIS FILE.
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mass
{
	public class MassInputs: S3Args
	{
		/// <summary>
		/// Overall height of the building from grade.
		/// </summary>
		[JsonProperty("Building Height")]
		public double BuildingHeight {get;}

		/// <summary>
		/// Depth of the building envelope below grade.
		/// </summary>
		[JsonProperty("Foundation Depth")]
		public double FoundationDepth {get;}

		/// <summary>
		/// Vertical distance between setbacks.
		/// </summary>
		[JsonProperty("Setback Interval")]
		public double SetbackInterval {get;}

		/// <summary>
		/// Depth of each setback from the previous plinth.
		/// </summary>
		[JsonProperty("Setback Depth")]
		public double SetbackDepth {get;}


		
		/// <summary>
		/// Construct a MassInputs with default inputs.
		/// This should be used only for testing.
		/// </summary>
		public MassInputs() : base()
		{
			this.BuildingHeight = 200;
			this.FoundationDepth = 20;
			this.SetbackInterval = 50;
			this.SetbackDepth = 10;

		}
		
		/// <summary>
		/// Construct a MassInputs specifying all inputs.
		/// </summary>
		/// <returns></returns>
		[JsonConstructor]
		public MassInputs(double buildingheight, double foundationdepth, double setbackinterval, double setbackdepth, string bucketName, string uploadsBucket, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, gltfKey, elementsKey, ifcKey)
		{
			this.BuildingHeight = buildingheight;
			this.FoundationDepth = foundationdepth;
			this.SetbackInterval = setbackinterval;
			this.SetbackDepth = setbackdepth;

		}
	}
}