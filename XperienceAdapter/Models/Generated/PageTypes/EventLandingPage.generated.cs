﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MedioClinic;

[assembly: RegisterDocumentType(EventLandingPage.CLASS_NAME, typeof(EventLandingPage))]

namespace CMS.DocumentEngine.Types.MedioClinic
{
	/// <summary>
	/// Represents a content item of type EventLandingPage.
	/// </summary>
	public partial class EventLandingPage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MedioClinic.EventLandingPage";


		/// <summary>
		/// The instance of the class that provides extended API for working with EventLandingPage fields.
		/// </summary>
		private readonly EventLandingPageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// EventLandingPageID.
		/// </summary>
		[DatabaseIDField]
		public int EventLandingPageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("EventLandingPageID"), 0);
			}
			set
			{
				SetValue("EventLandingPageID", value);
			}
		}


		/// <summary>
		/// Event date.
		/// </summary>
		[DatabaseField]
		public DateTime EventDate
		{
			get
			{
				return ValidationHelper.GetDateTime(GetValue("EventDate"), DateTimeHelper.ZERO_TIME);
			}
			set
			{
				SetValue("EventDate", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with EventLandingPage fields.
		/// </summary>
		[RegisterProperty]
		public EventLandingPageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with EventLandingPage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class EventLandingPageFields : AbstractHierarchicalObject<EventLandingPageFields>
		{
			/// <summary>
			/// The content item of type EventLandingPage that is a target of the extended API.
			/// </summary>
			private readonly EventLandingPage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="EventLandingPageFields" /> class with the specified content item of type EventLandingPage.
			/// </summary>
			/// <param name="instance">The content item of type EventLandingPage that is a target of the extended API.</param>
			public EventLandingPageFields(EventLandingPage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// EventLandingPageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.EventLandingPageID;
				}
				set
				{
					mInstance.EventLandingPageID = value;
				}
			}


			/// <summary>
			/// Event date.
			/// </summary>
			public DateTime EventDate
			{
				get
				{
					return mInstance.EventDate;
				}
				set
				{
					mInstance.EventDate = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="EventLandingPage" /> class.
		/// </summary>
		public EventLandingPage() : base(CLASS_NAME)
		{
			mFields = new EventLandingPageFields(this);
		}

		#endregion
	}
}