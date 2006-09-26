﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.Serialization;

using IdeaBlade.Persistence;
using IdeaBlade.Rdb;
using IdeaBlade.Persistence.Rdb;
using IdeaBlade.Util;

namespace TvDatabase {

  #region ProgramDataTable
  /// <summary>
  ///    ****************************************************
  ///    ** DO NOT MODIFY THIS CLASS - AutoGenerated Code
  ///    ** Any changes made to this code will be lost the
  ///    ** next time this code is regenerated.
  ///    **
  ///    ** Generated from: EntityBaseclass.template
  ///    ** Last modified : 2006-07-01T14:28:46.4375+02:00
  ///    ****************************************************
  ///</summary>
  [BindingBrowsable(false)]
  [Serializable]
  public partial class ProgramDataTable : IdeaBlade.Persistence.EntityTable , 
     IdeaBlade.Persistence.Rdb.IRdbTable {
  
    public ProgramDataTable() {}

    protected ProgramDataTable(SerializationInfo pInfo, StreamingContext pContext) :
      base(pInfo, pContext) {}

    protected override DataRow NewRowFromBuilder(DataRowBuilder pRowBuilder) {
      return new Program(pRowBuilder);
    }

    protected override Type GetRowType() {
      return typeof(Program);
    }
    
    public override String DataSourceKeyName {
      get { return @"default"; }
    }


    #region Column properties
    private DataColumn mIdProgramColumn;
    public DataColumn IdProgramColumn {
      get {
        if (mIdProgramColumn!=null) return mIdProgramColumn;
        mIdProgramColumn = GetColumn("IdProgram", true);
        return mIdProgramColumn;
      }
    }
    private DataColumn mIdChannelColumn;
    public DataColumn IdChannelColumn {
      get {
        if (mIdChannelColumn!=null) return mIdChannelColumn;
        mIdChannelColumn = GetColumn("IdChannel", true);
        return mIdChannelColumn;
      }
    }
    private DataColumn mStartTimeColumn;
    public DataColumn StartTimeColumn {
      get {
        if (mStartTimeColumn!=null) return mStartTimeColumn;
        mStartTimeColumn = GetColumn("StartTime", true);
        return mStartTimeColumn;
      }
    }
    private DataColumn mEndTimeColumn;
    public DataColumn EndTimeColumn {
      get {
        if (mEndTimeColumn!=null) return mEndTimeColumn;
        mEndTimeColumn = GetColumn("EndTime", true);
        return mEndTimeColumn;
      }
    }
    private DataColumn mTitleColumn;
    public DataColumn TitleColumn {
      get {
        if (mTitleColumn!=null) return mTitleColumn;
        mTitleColumn = GetColumn("Title", true);
        return mTitleColumn;
      }
    }
    private DataColumn mDescriptionColumn;
    public DataColumn DescriptionColumn {
      get {
        if (mDescriptionColumn!=null) return mDescriptionColumn;
        mDescriptionColumn = GetColumn("Description", true);
        return mDescriptionColumn;
      }
    }
    private DataColumn mGenreColumn;
    public DataColumn GenreColumn {
      get {
        if (mGenreColumn!=null) return mGenreColumn;
        mGenreColumn = GetColumn("Genre", true);
        return mGenreColumn;
      }
    }
    private DataColumn mNotifyColumn;
    public DataColumn NotifyColumn {
      get {
        if (mNotifyColumn!=null) return mNotifyColumn;
        mNotifyColumn = GetColumn("Notify", true);
        return mNotifyColumn;
      }
    }
    #endregion    

    protected override TableMappingInfo CreateTableMappingInfo() {
      RdbTableMappingInfo mappingInfo = new RdbTableMappingInfo(this);
      mappingInfo.SourceOwnerName = "dbo"; 
      mappingInfo.SourceTableName = "Program"; 
      mappingInfo.ConcurrencyColumnName = ""; 
      // ColumnSelectionOption: selectAllColumns
      mappingInfo.SourceColumnNames = "*"; 
   
      DataColumnMappingCollection columnMappings = mappingInfo.TableMapping.ColumnMappings;
      columnMappings.Clear();
      columnMappings.Add("idProgram", "IdProgram");
      columnMappings.Add("idChannel", "IdChannel");
      columnMappings.Add("startTime", "StartTime");
      columnMappings.Add("endTime", "EndTime");
      columnMappings.Add("title", "Title");
      columnMappings.Add("description", "Description");
      columnMappings.Add("genre", "Genre");
      columnMappings.Add("notify", "Notify");
      return mappingInfo;
    }
  
    protected override void UpdateTableMappingInfo() {
      base.UpdateTableMappingInfo();
    }

    public override void InitColumnProperties() {
      base.InitColumnProperties();

      IdProgramColumn.Caption = "idProgram";
      IdChannelColumn.Caption = "idChannel";
      StartTimeColumn.Caption = "startTime";
      EndTimeColumn.Caption = "endTime";
      TitleColumn.Caption = "title";
      DescriptionColumn.Caption = "description";
      GenreColumn.Caption = "genre";
      NotifyColumn.Caption = "notify";
    }
  }
  #endregion
  
  #region ProgramDataRow
  /// <summary>
  ///    ****************************************************
  ///    ** DO NOT MODIFY THIS CLASS - AutoGenerated Code
  ///    ** Any changes made to this code will be lost the
  ///    ** next time this code is regenerated
  ///    **
  ///    ** Generated from: EntityBaseclass.template
  ///    ** Generated on:   2006-07-01T14:28:46.4375+02:00
  ///    ****************************************************
  ///</summary>
  [Serializable]
  public abstract partial class ProgramDataRow : IdeaBlade.Persistence.Entity, 
     IdeaBlade.Persistence.Rdb.IRdbEntity {
  
    protected ProgramDataRow(DataRowBuilder pRowBuilder)
      : base(pRowBuilder) {
    }

    [BindingBrowsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public new ProgramDataTable TypedTable {
      get { return (ProgramDataTable) base.Table; }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static Type GetTableType() {
      return typeof(ProgramDataTable);
    }

    [BindingBrowsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public virtual string SqlWhereClause {
      get { return ""; }
    }
    
    [BindingBrowsable(false)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public virtual bool ForceSqlDistinct {
      get { return false; }
    }

    #region Enums
    //**************************************
    //* Enums
    //**************************************
    #endregion
	
    #region Relation properties
    //**************************************
    //* Relation properties
    //**************************************
    
    public virtual ReadOnlyEntityList<Favorite> Favorites {
      get { 
        ReadOnlyEntityList<Favorite> result;
        if (GetInterceptor<ReadOnlyEntityList<Favorite>>("Favorites", GetFavoritesCore, out result)) return result;
        return GetFavoritesCore();
      }
    }
    private ReadOnlyEntityList<Favorite> GetFavoritesCore() {
      return this.GetManagedChildren<Favorite>(EntityRelations.Program_Favorite);
    } 

    public virtual Channel Channel {
      get { 
        Channel result;
        if (GetInterceptor<Channel>("Channel", GetChannelCore, out result)) return result;
        return GetChannelCore();
      }
      set { 
        if (SetInterceptor<Channel>("Channel", value, SetChannelCore)) return;
        SetChannelCore(value);
      }
    }
    private Channel GetChannelCore() {
      return GetParent<Channel>(EntityRelations.Channel_Program, this.PersistenceManager.DefaultQueryStrategy);
    }
    private void SetChannelCore(Channel value) {
      if (value == null) {
        SetNull(this.IdChannelColumn);
      } else {
        SetColumnValue(this.IdChannelColumn, value, value.IdChannelColumn);
      }
      OnPropertyChanged(new PropertyChangedEventArgs("Channel"));
    }

    #endregion
    
    #region EntityColumn definitions
    //**************************************
    //* Static EntityColumn definitions
    //**************************************

    public static readonly EntityColumn IdProgramEntityColumn =
      new EntityColumn(typeof(Program), "IdProgram", typeof(System.Int32), false, true, true, DataSourceAccessType.ReadWrite);      
    public static readonly EntityColumn IdChannelEntityColumn =
      new EntityColumn(typeof(Program), "IdChannel", typeof(System.Int32), false, false, false, DataSourceAccessType.ReadWrite);      
    public static readonly EntityColumn StartTimeEntityColumn =
      new EntityColumn(typeof(Program), "StartTime", typeof(System.DateTime), false, false, false, DataSourceAccessType.ReadWrite);      
    public static readonly EntityColumn EndTimeEntityColumn =
      new EntityColumn(typeof(Program), "EndTime", typeof(System.DateTime), false, false, false, DataSourceAccessType.ReadWrite);      
    public static readonly EntityColumn TitleEntityColumn =
      new EntityColumn(typeof(Program), "Title", typeof(System.String), false, false, false, DataSourceAccessType.ReadWrite);      
    public static readonly EntityColumn DescriptionEntityColumn =
      new EntityColumn(typeof(Program), "Description", typeof(System.String), false, false, false, DataSourceAccessType.ReadWrite);      
    public static readonly EntityColumn GenreEntityColumn =
      new EntityColumn(typeof(Program), "Genre", typeof(System.String), false, false, false, DataSourceAccessType.ReadWrite);      
    public static readonly EntityColumn NotifyEntityColumn =
      new EntityColumn(typeof(Program), "Notify", typeof(System.Boolean), false, false, false, DataSourceAccessType.ReadWrite);      
    #endregion
    
    #region Properties
    //**************************************
    //* IdProgram methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn IdProgramColumn {
      get { return TypedTable.IdProgramColumn; }
    }

    [DBDataType(typeof(System.Int32))]
    public virtual System.Int32 IdProgram {
      get { 
        System.Int32 result;
        if (GetInterceptor<System.Int32>("IdProgram", GetIdProgramCore, out result)) return result;
        return GetIdProgramCore();
      }
    }
    private System.Int32 GetIdProgramCore() {
      return (System.Int32) GetColumnValue(IdProgramColumn, typeof(System.Int32), false); 
    }
        
    //**************************************
    //* IdChannel methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn IdChannelColumn {
      get { return TypedTable.IdChannelColumn; }
    }

    [DBDataType(typeof(System.Int32))]
    public virtual System.Int32 IdChannel {
      get { 
        System.Int32 result;
        if (GetInterceptor<System.Int32>("IdChannel", GetIdChannelCore, out result)) return result;
        return GetIdChannelCore();
      }
      set { 
        if (SetInterceptor<System.Int32>("IdChannel", value, SetIdChannelCore)) return;
        SetIdChannelCore(value);
      }
    }
    private System.Int32 GetIdChannelCore() {
      return (System.Int32) GetColumnValue(IdChannelColumn, typeof(System.Int32), false); 
    }
    private void SetIdChannelCore(System.Int32 value) {
      SetColumnValue(IdChannelColumn, value);
    }
        
    //**************************************
    //* StartTime methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn StartTimeColumn {
      get { return TypedTable.StartTimeColumn; }
    }

    [DBDataType(typeof(System.DateTime))]
    public virtual System.DateTime StartTime {
      get { 
        System.DateTime result;
        if (GetInterceptor<System.DateTime>("StartTime", GetStartTimeCore, out result)) return result;
        return GetStartTimeCore();
      }
      set { 
        if (SetInterceptor<System.DateTime>("StartTime", value, SetStartTimeCore)) return;
        SetStartTimeCore(value);
      }
    }
    private System.DateTime GetStartTimeCore() {
      return (System.DateTime) GetColumnValue(StartTimeColumn, typeof(System.DateTime), false); 
    }
    private void SetStartTimeCore(System.DateTime value) {
      SetColumnValue(StartTimeColumn, value);
    }
        
    //**************************************
    //* EndTime methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn EndTimeColumn {
      get { return TypedTable.EndTimeColumn; }
    }

    [DBDataType(typeof(System.DateTime))]
    public virtual System.DateTime EndTime {
      get { 
        System.DateTime result;
        if (GetInterceptor<System.DateTime>("EndTime", GetEndTimeCore, out result)) return result;
        return GetEndTimeCore();
      }
      set { 
        if (SetInterceptor<System.DateTime>("EndTime", value, SetEndTimeCore)) return;
        SetEndTimeCore(value);
      }
    }
    private System.DateTime GetEndTimeCore() {
      return (System.DateTime) GetColumnValue(EndTimeColumn, typeof(System.DateTime), false); 
    }
    private void SetEndTimeCore(System.DateTime value) {
      SetColumnValue(EndTimeColumn, value);
    }
        
    //**************************************
    //* Title methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn TitleColumn {
      get { return TypedTable.TitleColumn; }
    }

    [MaxTextLength(2000)]
    [DBDataType(typeof(System.String))]
    public virtual System.String Title {
      get { 
        System.String result;
        if (GetInterceptor<System.String>("Title", GetTitleCore, out result)) return result;
        return GetTitleCore();
      }
      set { 
        if (SetInterceptor<System.String>("Title", value, SetTitleCore)) return;
        SetTitleCore(value);
      }
    }
    private System.String GetTitleCore() {
      return (System.String) GetColumnValue(TitleColumn, typeof(System.String), false); 
    }
    private void SetTitleCore(System.String value) {
      SetColumnValue(TitleColumn, value);
    }
        
    //**************************************
    //* Description methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn DescriptionColumn {
      get { return TypedTable.DescriptionColumn; }
    }

    [MaxTextLength(4000)]
    [DBDataType(typeof(System.String))]
    public virtual System.String Description {
      get { 
        System.String result;
        if (GetInterceptor<System.String>("Description", GetDescriptionCore, out result)) return result;
        return GetDescriptionCore();
      }
      set { 
        if (SetInterceptor<System.String>("Description", value, SetDescriptionCore)) return;
        SetDescriptionCore(value);
      }
    }
    private System.String GetDescriptionCore() {
      return (System.String) GetColumnValue(DescriptionColumn, typeof(System.String), false); 
    }
    private void SetDescriptionCore(System.String value) {
      SetColumnValue(DescriptionColumn, value);
    }
        
    //**************************************
    //* Genre methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn GenreColumn {
      get { return TypedTable.GenreColumn; }
    }

    [MaxTextLength(200)]
    [DBDataType(typeof(System.String))]
    public virtual System.String Genre {
      get { 
        System.String result;
        if (GetInterceptor<System.String>("Genre", GetGenreCore, out result)) return result;
        return GetGenreCore();
      }
      set { 
        if (SetInterceptor<System.String>("Genre", value, SetGenreCore)) return;
        SetGenreCore(value);
      }
    }
    private System.String GetGenreCore() {
      return (System.String) GetColumnValue(GenreColumn, typeof(System.String), false); 
    }
    private void SetGenreCore(System.String value) {
      SetColumnValue(GenreColumn, value);
    }
        
    //**************************************
    //* Notify methods
    //**************************************
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [BindingBrowsable(false)]
    public virtual DataColumn NotifyColumn {
      get { return TypedTable.NotifyColumn; }
    }

    [DBDataType(typeof(System.Boolean))]
    public virtual System.Boolean Notify {
      get { 
        System.Boolean result;
        if (GetInterceptor<System.Boolean>("Notify", GetNotifyCore, out result)) return result;
        return GetNotifyCore();
      }
      set { 
        if (SetInterceptor<System.Boolean>("Notify", value, SetNotifyCore)) return;
        SetNotifyCore(value);
      }
    }
    private System.Boolean GetNotifyCore() {
      return (System.Boolean) GetColumnValue(NotifyColumn, typeof(System.Boolean), false); 
    }
    private void SetNotifyCore(System.Boolean value) {
      SetColumnValue(NotifyColumn, value);
    }
        
    #endregion
    
  }
  #endregion
}
