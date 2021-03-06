//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Testing_CoreV2NetCore
{
   public partial class Child
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Child()
      {
         Children = new System.Collections.Generic.HashSet<global::Testing_CoreV2NetCore.Child>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="parent"></param>
      /// <param name="_master0"></param>
      public Child(global::Testing_CoreV2NetCore.Child parent, global::Testing_CoreV2NetCore.Master _master0)
      {
         if (parent == null) throw new ArgumentNullException(nameof(parent));
         this.Parent = parent;

         if (_master0 == null) throw new ArgumentNullException(nameof(_master0));
         _master0.Children.Add(this);

         this.Children = new System.Collections.Generic.HashSet<global::Testing_CoreV2NetCore.Child>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="parent"></param>
      /// <param name="_master0"></param>
      public static Child Create(global::Testing_CoreV2NetCore.Child parent, global::Testing_CoreV2NetCore.Master _master0)
      {
         return new Child(parent, _master0);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; private set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      public virtual ICollection<global::Testing_CoreV2NetCore.Child> Children { get; private set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing_CoreV2NetCore.Child Parent { get; set; }

   }
}

