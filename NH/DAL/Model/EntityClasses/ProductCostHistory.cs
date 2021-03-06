﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductCostHistory'</summary>
	public partial class ProductCostHistory
	{
		#region Class Member Declarations
		private Product _product;
		private Nullable<System.DateTime> _endDate;
		private System.DateTime _modifiedDate;
		private System.Decimal _standardCost;
		private System.DateTime _startDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductCostHistory"/> class.</summary>
		public ProductCostHistory() : base()
		{
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj);
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the EndDate field. </summary>	
		public virtual Nullable<System.DateTime> EndDate
		{ 
			get { return _endDate; }
			set { _endDate = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the StandardCost field. </summary>	
		public virtual System.Decimal StandardCost
		{ 
			get { return _standardCost; }
			set { _standardCost = value; }
		}

		/// <summary>Gets or sets the StartDate field. </summary>	
		public virtual System.DateTime StartDate
		{ 
			get { return _startDate; }
			set { _startDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'ProductCostHistory.Product - Product.ProductCostHistories (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		#endregion
	}
}
