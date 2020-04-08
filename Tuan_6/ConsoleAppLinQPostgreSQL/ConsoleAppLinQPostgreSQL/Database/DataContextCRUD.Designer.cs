﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 08/04/2020 5:07:31 CH
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace DbCrudContext
{

    [DatabaseAttribute(Name = "db_crud")]
    [ProviderAttribute(typeof(Devart.Data.PostgreSql.Linq.Provider.PgSqlDataProvider))]
    public partial class DbCrudDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(DbCrudDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertCrud(Crud instance);
        partial void UpdateCrud(Crud instance);
        partial void DeleteCrud(Crud instance);

        #endregion

        public DbCrudDataContext() :
        base(@"User Id=postgres;Password=suong123;Host=localhost;Database=db_crud;Persist Security Info=True;Initial Schema=public", mappingSource)
        {
            OnCreated();
        }

        public DbCrudDataContext(MappingSource mappingSource) :
        base(@"User Id=postgres;Password=suong123;Host=localhost;Database=db_crud;Persist Security Info=True;Initial Schema=public", mappingSource)
        {
            OnCreated();
        }

        public DbCrudDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public DbCrudDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public DbCrudDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public DbCrudDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Crud> Cruds
        {
            get
            {
                return this.GetTable<Crud>();
            }
        }
    }
}

namespace DbCrudContext
{

    /// <summary>
    /// There are no comments for DbCrudContext.Crud in the schema.
    /// </summary>
    [Table(Name = @"public.crud")]
    public partial class Crud : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private long _Id;

        private string _FirstName;

        private string _LastName;

        private string _Gender;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(long value);
        partial void OnIdChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnGenderChanging(string value);
        partial void OnGenderChanged();
        #endregion

        public Crud()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [Column(Name = @"id", Storage = "_Id", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "BIGSERIAL NOT NULL", IsDbGenerated = true, IsPrimaryKey = true)]
        public long Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging("Id");
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        [Column(Name = @"first_name", Storage = "_FirstName", DbType = "TEXT", UpdateCheck = UpdateCheck.Never)]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if (this._FirstName != value)
                {
                    this.OnFirstNameChanging(value);
                    this.SendPropertyChanging("FirstName");
                    this._FirstName = value;
                    this.SendPropertyChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        [Column(Name = @"last_name", Storage = "_LastName", DbType = "TEXT", UpdateCheck = UpdateCheck.Never)]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if (this._LastName != value)
                {
                    this.OnLastNameChanging(value);
                    this.SendPropertyChanging("LastName");
                    this._LastName = value;
                    this.SendPropertyChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Gender in the schema.
        /// </summary>
        [Column(Name = @"gender", Storage = "_Gender", DbType = "TEXT", UpdateCheck = UpdateCheck.Never)]
        public string Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                if (this._Gender != value)
                {
                    this.OnGenderChanging(value);
                    this.SendPropertyChanging("Gender");
                    this._Gender = value;
                    this.SendPropertyChanged("Gender");
                    this.OnGenderChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
