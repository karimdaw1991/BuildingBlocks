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

namespace Story
{
	public class StoryInputs: S3Args
	{
		/// <summary>
		/// Typical story height.
		/// </summary>
		[JsonProperty("Story height")]
		public double StoryHeight {get;}

		/// <summary>
		/// Offset from the enclosing envelope of the story.
		/// </summary>
		[JsonProperty("Envelope offset")]
		public double EnvelopeOffset {get;}

		/// <summary>
		/// Quantity of rooms on each floor.
		/// </summary>
		[JsonProperty("Rooms Per Story")]
		public double RoomsPerStory {get;}

		/// <summary>
		/// Corridor width.
		/// </summary>
		[JsonProperty("Corridor Width")]
		public double CorridorWidth {get;}


		
		/// <summary>
		/// Construct a StoryInputs with default inputs.
		/// This should be used only for testing.
		/// </summary>
		public StoryInputs() : base()
		{
			this.StoryHeight = 5;
			this.EnvelopeOffset = 1;
			this.RoomsPerStory = 20;
			this.CorridorWidth = 4;

		}
		
		/// <summary>
		/// Construct a StoryInputs specifying all inputs.
		/// </summary>
		/// <returns></returns>
		[JsonConstructor]
		public StoryInputs(double storyheight, double envelopeoffset, double roomsperstory, double corridorwidth, string bucketName, string uploadsBucket, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, gltfKey, elementsKey, ifcKey)
		{
			this.StoryHeight = storyheight;
			this.EnvelopeOffset = envelopeoffset;
			this.RoomsPerStory = roomsperstory;
			this.CorridorWidth = corridorwidth;

		}
	}
}