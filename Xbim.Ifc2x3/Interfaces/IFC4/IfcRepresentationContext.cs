// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.RepresentationResource
{
	public partial class @IfcRepresentationContext : IIfcRepresentationContext
	{
		Ifc4.MeasureResource.IfcLabel? IIfcRepresentationContext.ContextIdentifier 
		{ 
			get
			{
				if (!ContextIdentifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ContextIdentifier.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcRepresentationContext.ContextType 
		{ 
			get
			{
				if (!ContextType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ContextType.Value);
			} 
		}
		IEnumerable<IIfcRepresentation> IIfcRepresentationContext.RepresentationsInContext 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRepresentation>(e => (e.ContextOfItems as IfcRepresentationContext) == this);
			} 
		}
	}
}