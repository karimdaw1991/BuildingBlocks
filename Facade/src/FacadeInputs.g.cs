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

namespace Facade
{
	public class FacadeInputs: S3Args
	{
		/// <summary>
		/// Vertical divisions of each facade.
		/// </summary>
		[JsonProperty("Vertical Panels Per Facade")]
		public double VerticalPanelsPerFacade {get;}

		/// <summary>
		/// Horizontal divisions of each facade panel.
		/// </summary>
		[JsonProperty("Horizontal Panels Per Facade")]
		public double HorizontalPanelsPerFacade {get;}

		/// <summary>
		/// Width of each mullion.
		/// </summary>
		[JsonProperty("Mullion Width")]
		public double MullionWidth {get;}


		
		/// <summary>
		/// Construct a FacadeInputs with default inputs.
		/// This should be used only for testing.
		/// </summary>
		public FacadeInputs() : base()
		{
			this.VerticalPanelsPerFacade = 20;
			this.HorizontalPanelsPerFacade = 20;
			this.MullionWidth = 0.5;

		}
		
		/// <summary>
		/// Construct a FacadeInputs specifying all inputs.
		/// </summary>
		/// <returns></returns>
		[JsonConstructor]
		public FacadeInputs(double verticalpanelsperfacade, double horizontalpanelsperfacade, double mullionwidth, string bucketName, string uploadsBucket, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, gltfKey, elementsKey, ifcKey)
		{
			this.VerticalPanelsPerFacade = verticalpanelsperfacade;
			this.HorizontalPanelsPerFacade = horizontalpanelsperfacade;
			this.MullionWidth = mullionwidth;

		}
	}
}