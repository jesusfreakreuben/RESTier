﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Restier.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Restier.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling the methods in &apos;QueryableSource&apos; or &apos;QueryableSource&lt;T&gt;&apos; is not supported..
        /// </summary>
        internal static string CallQueryableSourceMethodNotSupported {
            get {
                return ResourceManager.GetString("CallQueryableSourceMethodNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The change set cannot be set if there is already a result..
        /// </summary>
        internal static string CannotSetChangeSetIfThereIsResult {
            get {
                return ResourceManager.GetString("CannotSetChangeSetIfThereIsResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The results source cannot be set if there is any error..
        /// </summary>
        internal static string CannotSetResultsSourceIfThereIsAnyError {
            get {
                return ResourceManager.GetString("CannotSetResultsSourceIfThereIsAnyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The total count cannot be set if there is no result yet..
        /// </summary>
        internal static string CannotSetTotalCountIfThereIsNoResult {
            get {
                return ResourceManager.GetString("CannotSetTotalCountIfThereIsNoResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change set preparer is missing..
        /// </summary>
        internal static string ChangeSetPreparerMissing {
            get {
                return ResourceManager.GetString("ChangeSetPreparerMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A DataModification must be either: IsNew, IsUpdate, or IsDelete..
        /// </summary>
        internal static string DataModificationMustBeCUD {
            get {
                return ResourceManager.GetString("DataModificationMustBeCUD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;DataModificationItem.ApplyTo cannot be called on an new resource..
        /// </summary>
        internal static string DataModificationNotSupportCreateResource {
            get {
                return ResourceManager.GetString("DataModificationNotSupportCreateResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There should have been at least one predicate applied to the query from the resource key.  Ensure there is at least one resource key..
        /// </summary>
        internal static string DataModificationRequiresResourceKey {
            get {
                return ResourceManager.GetString("DataModificationRequiresResourceKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not call the methods in &apos;DataSourceStub&apos; directly..
        /// </summary>
        internal static string DoNotCallDataSourceStubMethodDirectly {
            get {
                return ResourceManager.GetString("DoNotCallDataSourceStubMethodDirectly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a supported EDM type..
        /// </summary>
        internal static string EdmTypeNotSupported {
            get {
                return ResourceManager.GetString("EdmTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element type cannot be found for &apos;{0}&apos;..
        /// </summary>
        internal static string ElementTypeNotFound {
            get {
                return ResourceManager.GetString("ElementTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element type not match..
        /// </summary>
        internal static string ElementTypeNotMatch {
            get {
                return ResourceManager.GetString("ElementTypeNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expander cannot change the expression type..
        /// </summary>
        internal static string ExpanderCannotChangeExpressionType {
            get {
                return ResourceManager.GetString("ExpanderCannotChangeExpressionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression must be queryable..
        /// </summary>
        internal static string ExpressionMustBeQueryable {
            get {
                return ResourceManager.GetString("ExpressionMustBeQueryable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inspection failed..
        /// </summary>
        internal static string InspectionFailed {
            get {
                return ResourceManager.GetString("InspectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid ChangeSetItem Type: {0}..
        /// </summary>
        internal static string InvalidChangeSetEntryType {
            get {
                return ResourceManager.GetString("InvalidChangeSetEntryType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IEdmModel cannot be generated since API service IModelBuilder is not registered..
        /// </summary>
        internal static string ModelBuilderNotRegistered {
            get {
                return ResourceManager.GetString("ModelBuilderNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current user does not have permission to delete entities from the EntitySet &apos;{0}&apos;..
        /// </summary>
        internal static string NoPermissionToDeleteEntity {
            get {
                return ResourceManager.GetString("NoPermissionToDeleteEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current user does not have permission to insert entities into the EntitySet &apos;{0}&apos;..
        /// </summary>
        internal static string NoPermissionToInsertEntity {
            get {
                return ResourceManager.GetString("NoPermissionToInsertEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current user does not have permission to invoke the requested action &apos;{0}&apos;..
        /// </summary>
        internal static string NoPermissionToInvokeAction {
            get {
                return ResourceManager.GetString("NoPermissionToInvokeAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current user does not have permission to update entities in the EntitySet &apos;{0}&apos;..
        /// </summary>
        internal static string NoPermissionToUpdateEntity {
            get {
                return ResourceManager.GetString("NoPermissionToUpdateEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported type: {0}..
        /// </summary>
        internal static string NotSupportedType {
            get {
                return ResourceManager.GetString("NotSupportedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Original query expression should be constant expression..
        /// </summary>
        internal static string OriginalExpressionShouldBeConstant {
            get {
                return ResourceManager.GetString("OriginalExpressionShouldBeConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Original query expression should contain a value which is queryable..
        /// </summary>
        internal static string OriginalExpressionShouldBeQueryable {
            get {
                return ResourceManager.GetString("OriginalExpressionShouldBeQueryable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The precondition check for request {0} on resource {1} is failed..
        /// </summary>
        internal static string PreconditionCheckFailed {
            get {
                return ResourceManager.GetString("PreconditionCheckFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processor cannot change the expression type..
        /// </summary>
        internal static string ProcessorCannotChangeExpressionType {
            get {
                return ResourceManager.GetString("ProcessorCannotChangeExpressionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;QueryableSource&apos; cannot be used as query..
        /// </summary>
        internal static string QueryableSourceCannotBeUsedAsQuery {
            get {
                return ResourceManager.GetString("QueryableSourceCannotBeUsedAsQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query executor is missing..
        /// </summary>
        internal static string QueryExecutorMissing {
            get {
                return ResourceManager.GetString("QueryExecutorMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression sourcer is missing..
        /// </summary>
        internal static string QuerySourcerMissing {
            get {
                return ResourceManager.GetString("QuerySourcerMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request resource is not found..
        /// </summary>
        internal static string ResourceNotFound {
            get {
                return ResourceManager.GetString("ResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Should specify an interface type T for the handler..
        /// </summary>
        internal static string ShouldBeInterfaceType {
            get {
                return ResourceManager.GetString("ShouldBeInterfaceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression returned by sourcer is missing..
        /// </summary>
        internal static string SourceExpressionMissing {
            get {
                return ResourceManager.GetString("SourceExpressionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit executor is missing..
        /// </summary>
        internal static string SubmitExecutorMissing {
            get {
                return ResourceManager.GetString("SubmitExecutorMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be performed because one or more objects are invalid.  Please inspect the ChangeSetValidationException.ValidationResults property for more information..
        /// </summary>
        internal static string ValidationFailsTheOperation {
            get {
                return ResourceManager.GetString("ValidationFailsTheOperation", resourceCulture);
            }
        }
    }
}
