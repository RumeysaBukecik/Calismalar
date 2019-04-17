﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sinema_Linq_Pro
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SINEMA")]
	public partial class SINEMA_DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertYayin(Yayin instance);
    partial void UpdateYayin(Yayin instance);
    partial void DeleteYayin(Yayin instance);
    partial void InsertSalon(Salon instance);
    partial void UpdateSalon(Salon instance);
    partial void DeleteSalon(Salon instance);
    partial void InsertFilm(Film instance);
    partial void UpdateFilm(Film instance);
    partial void DeleteFilm(Film instance);
    #endregion
		
		public SINEMA_DataContext() : 
				base(global::Sinema_Linq_Pro.Properties.Settings.Default.SINEMAConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SINEMA_DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SINEMA_DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SINEMA_DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SINEMA_DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Yayin> Yayins
		{
			get
			{
				return this.GetTable<Yayin>();
			}
		}
		
		public System.Data.Linq.Table<Salon> Salons
		{
			get
			{
				return this.GetTable<Salon>();
			}
		}
		
		public System.Data.Linq.Table<Yayin_Isimli> Yayin_Isimlis
		{
			get
			{
				return this.GetTable<Yayin_Isimli>();
			}
		}
		
		public System.Data.Linq.Table<Film> Films
		{
			get
			{
				return this.GetTable<Film>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_FilmKaydet")]
		public int SP_FilmKaydet([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] ref System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FilmAdi", DbType="NVarChar(250)")] string filmAdi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FilmKisaBilgi", DbType="NVarChar(500)")] string filmKisaBilgi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FilmFragmanLink", DbType="NVarChar(350)")] string filmFragmanLink)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, filmAdi, filmKisaBilgi, filmFragmanLink);
			iD = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Yayin")]
	public partial class Yayin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _YayinID;
		
		private int _FilmID;
		
		private int _SalonID;
		
		private System.DateTime _FYZaman;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnYayinIDChanging(int value);
    partial void OnYayinIDChanged();
    partial void OnFilmIDChanging(int value);
    partial void OnFilmIDChanged();
    partial void OnSalonIDChanging(int value);
    partial void OnSalonIDChanged();
    partial void OnFYZamanChanging(System.DateTime value);
    partial void OnFYZamanChanged();
    #endregion
		
		public Yayin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YayinID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int YayinID
		{
			get
			{
				return this._YayinID;
			}
			set
			{
				if ((this._YayinID != value))
				{
					this.OnYayinIDChanging(value);
					this.SendPropertyChanging();
					this._YayinID = value;
					this.SendPropertyChanged("YayinID");
					this.OnYayinIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmID", DbType="Int NOT NULL")]
		public int FilmID
		{
			get
			{
				return this._FilmID;
			}
			set
			{
				if ((this._FilmID != value))
				{
					this.OnFilmIDChanging(value);
					this.SendPropertyChanging();
					this._FilmID = value;
					this.SendPropertyChanged("FilmID");
					this.OnFilmIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalonID", DbType="Int NOT NULL")]
		public int SalonID
		{
			get
			{
				return this._SalonID;
			}
			set
			{
				if ((this._SalonID != value))
				{
					this.OnSalonIDChanging(value);
					this.SendPropertyChanging();
					this._SalonID = value;
					this.SendPropertyChanged("SalonID");
					this.OnSalonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FYZaman", DbType="DateTime NOT NULL")]
		public System.DateTime FYZaman
		{
			get
			{
				return this._FYZaman;
			}
			set
			{
				if ((this._FYZaman != value))
				{
					this.OnFYZamanChanging(value);
					this.SendPropertyChanging();
					this._FYZaman = value;
					this.SendPropertyChanged("FYZaman");
					this.OnFYZamanChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salon")]
	public partial class Salon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SalonID;
		
		private string _SalonAdi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalonIDChanging(int value);
    partial void OnSalonIDChanged();
    partial void OnSalonAdiChanging(string value);
    partial void OnSalonAdiChanged();
    #endregion
		
		public Salon()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalonID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SalonID
		{
			get
			{
				return this._SalonID;
			}
			set
			{
				if ((this._SalonID != value))
				{
					this.OnSalonIDChanging(value);
					this.SendPropertyChanging();
					this._SalonID = value;
					this.SendPropertyChanged("SalonID");
					this.OnSalonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalonAdi", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string SalonAdi
		{
			get
			{
				return this._SalonAdi;
			}
			set
			{
				if ((this._SalonAdi != value))
				{
					this.OnSalonAdiChanging(value);
					this.SendPropertyChanging();
					this._SalonAdi = value;
					this.SendPropertyChanged("SalonAdi");
					this.OnSalonAdiChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Yayin_Isimli")]
	public partial class Yayin_Isimli
	{
		
		private string _FilmAdi;
		
		private string _SalonAdi;
		
		private System.DateTime _FYZaman;
		
		public Yayin_Isimli()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmAdi", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string FilmAdi
		{
			get
			{
				return this._FilmAdi;
			}
			set
			{
				if ((this._FilmAdi != value))
				{
					this._FilmAdi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalonAdi", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string SalonAdi
		{
			get
			{
				return this._SalonAdi;
			}
			set
			{
				if ((this._SalonAdi != value))
				{
					this._SalonAdi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FYZaman", DbType="DateTime NOT NULL")]
		public System.DateTime FYZaman
		{
			get
			{
				return this._FYZaman;
			}
			set
			{
				if ((this._FYZaman != value))
				{
					this._FYZaman = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Film")]
	public partial class Film : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FilmID;
		
		private string _FilmAdi;
		
		private string _FilmKisaBilgi;
		
		private string _FilmFragmanLink;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFilmIDChanging(int value);
    partial void OnFilmIDChanged();
    partial void OnFilmAdiChanging(string value);
    partial void OnFilmAdiChanged();
    partial void OnFilmKisaBilgiChanging(string value);
    partial void OnFilmKisaBilgiChanged();
    partial void OnFilmFragmanLinkChanging(string value);
    partial void OnFilmFragmanLinkChanged();
    #endregion
		
		public Film()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FilmID
		{
			get
			{
				return this._FilmID;
			}
			set
			{
				if ((this._FilmID != value))
				{
					this.OnFilmIDChanging(value);
					this.SendPropertyChanging();
					this._FilmID = value;
					this.SendPropertyChanged("FilmID");
					this.OnFilmIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmAdi", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string FilmAdi
		{
			get
			{
				return this._FilmAdi;
			}
			set
			{
				if ((this._FilmAdi != value))
				{
					this.OnFilmAdiChanging(value);
					this.SendPropertyChanging();
					this._FilmAdi = value;
					this.SendPropertyChanged("FilmAdi");
					this.OnFilmAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmKisaBilgi", DbType="NVarChar(500)")]
		public string FilmKisaBilgi
		{
			get
			{
				return this._FilmKisaBilgi;
			}
			set
			{
				if ((this._FilmKisaBilgi != value))
				{
					this.OnFilmKisaBilgiChanging(value);
					this.SendPropertyChanging();
					this._FilmKisaBilgi = value;
					this.SendPropertyChanged("FilmKisaBilgi");
					this.OnFilmKisaBilgiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmFragmanLink", DbType="NVarChar(350)")]
		public string FilmFragmanLink
		{
			get
			{
				return this._FilmFragmanLink;
			}
			set
			{
				if ((this._FilmFragmanLink != value))
				{
					this.OnFilmFragmanLinkChanging(value);
					this.SendPropertyChanging();
					this._FilmFragmanLink = value;
					this.SendPropertyChanged("FilmFragmanLink");
					this.OnFilmFragmanLinkChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591