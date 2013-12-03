﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class CreativityEventDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertEvent(Event instance);
  partial void UpdateEvent(Event instance);
  partial void DeleteEvent(Event instance);
  partial void InsertSpreker(Spreker instance);
  partial void UpdateSpreker(Spreker instance);
  partial void DeleteSpreker(Spreker instance);
  partial void InsertAanwezig(Aanwezig instance);
  partial void UpdateAanwezig(Aanwezig instance);
  partial void DeleteAanwezig(Aanwezig instance);
  partial void InsertComment(Comment instance);
  partial void UpdateComment(Comment instance);
  partial void DeleteComment(Comment instance);
  #endregion
	
	public CreativityEventDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CreativityEventDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CreativityEventDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CreativityEventDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CreativityEventDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
	
	public System.Data.Linq.Table<Event> Events
	{
		get
		{
			return this.GetTable<Event>();
		}
	}
	
	public System.Data.Linq.Table<Spreker> Sprekers
	{
		get
		{
			return this.GetTable<Spreker>();
		}
	}
	
	public System.Data.Linq.Table<Aanwezig> Aanwezigs
	{
		get
		{
			return this.GetTable<Aanwezig>();
		}
	}
	
	public System.Data.Linq.Table<Comment> Comments
	{
		get
		{
			return this.GetTable<Comment>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _naam;
	
	private string _voornaam;
	
	private string _email;
	
	private string _gebruikersnaam;
	
	private string _wachtwoord;
	
	private string _rol;
	
	private EntitySet<Event> _Events;
	
	private EntitySet<Aanwezig> _Aanwezigs;
	
	private EntitySet<Comment> _Comments;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnaamChanging(string value);
    partial void OnnaamChanged();
    partial void OnvoornaamChanging(string value);
    partial void OnvoornaamChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OngebruikersnaamChanging(string value);
    partial void OngebruikersnaamChanged();
    partial void OnwachtwoordChanging(string value);
    partial void OnwachtwoordChanged();
    partial void OnrolChanging(string value);
    partial void OnrolChanged();
    #endregion
	
	public User()
	{
		this._Events = new EntitySet<Event>(new Action<Event>(this.attach_Events), new Action<Event>(this.detach_Events));
		this._Aanwezigs = new EntitySet<Aanwezig>(new Action<Aanwezig>(this.attach_Aanwezigs), new Action<Aanwezig>(this.detach_Aanwezigs));
		this._Comments = new EntitySet<Comment>(new Action<Comment>(this.attach_Comments), new Action<Comment>(this.detach_Comments));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_naam", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
	public string naam
	{
		get
		{
			return this._naam;
		}
		set
		{
			if ((this._naam != value))
			{
				this.OnnaamChanging(value);
				this.SendPropertyChanging();
				this._naam = value;
				this.SendPropertyChanged("naam");
				this.OnnaamChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_voornaam", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
	public string voornaam
	{
		get
		{
			return this._voornaam;
		}
		set
		{
			if ((this._voornaam != value))
			{
				this.OnvoornaamChanging(value);
				this.SendPropertyChanging();
				this._voornaam = value;
				this.SendPropertyChanged("voornaam");
				this.OnvoornaamChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
	public string email
	{
		get
		{
			return this._email;
		}
		set
		{
			if ((this._email != value))
			{
				this.OnemailChanging(value);
				this.SendPropertyChanging();
				this._email = value;
				this.SendPropertyChanged("email");
				this.OnemailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gebruikersnaam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string gebruikersnaam
	{
		get
		{
			return this._gebruikersnaam;
		}
		set
		{
			if ((this._gebruikersnaam != value))
			{
				this.OngebruikersnaamChanging(value);
				this.SendPropertyChanging();
				this._gebruikersnaam = value;
				this.SendPropertyChanged("gebruikersnaam");
				this.OngebruikersnaamChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wachtwoord", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
	public string wachtwoord
	{
		get
		{
			return this._wachtwoord;
		}
		set
		{
			if ((this._wachtwoord != value))
			{
				this.OnwachtwoordChanging(value);
				this.SendPropertyChanging();
				this._wachtwoord = value;
				this.SendPropertyChanged("wachtwoord");
				this.OnwachtwoordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rol", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
	public string rol
	{
		get
		{
			return this._rol;
		}
		set
		{
			if ((this._rol != value))
			{
				this.OnrolChanging(value);
				this.SendPropertyChanging();
				this._rol = value;
				this.SendPropertyChanged("rol");
				this.OnrolChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Event", Storage="_Events", ThisKey="Id", OtherKey="eigenaar")]
	public EntitySet<Event> Events
	{
		get
		{
			return this._Events;
		}
		set
		{
			this._Events.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Aanwezig", Storage="_Aanwezigs", ThisKey="Id", OtherKey="PersoonId")]
	public EntitySet<Aanwezig> Aanwezigs
	{
		get
		{
			return this._Aanwezigs;
		}
		set
		{
			this._Aanwezigs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Comment", Storage="_Comments", ThisKey="Id", OtherKey="persoonId")]
	public EntitySet<Comment> Comments
	{
		get
		{
			return this._Comments;
		}
		set
		{
			this._Comments.Assign(value);
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
	
	private void attach_Events(Event entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_Events(Event entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
	
	private void attach_Aanwezigs(Aanwezig entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_Aanwezigs(Aanwezig entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
	
	private void attach_Comments(Comment entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_Comments(Comment entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _naam;
	
	private string _informatie;
	
	private System.DateTime _datum;
	
	private System.Nullable<int> _visitors;
	
	private System.Nullable<int> _eigenaar;
	
	private string _sprekers;
	
	private EntitySet<Spreker> _Sprekers1;
	
	private EntitySet<Aanwezig> _Aanwezigs;
	
	private EntitySet<Comment> _Comments;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnaamChanging(string value);
    partial void OnnaamChanged();
    partial void OninformatieChanging(string value);
    partial void OninformatieChanged();
    partial void OndatumChanging(System.DateTime value);
    partial void OndatumChanged();
    partial void OnvisitorsChanging(System.Nullable<int> value);
    partial void OnvisitorsChanged();
    partial void OneigenaarChanging(System.Nullable<int> value);
    partial void OneigenaarChanged();
    partial void OnsprekersChanging(string value);
    partial void OnsprekersChanged();
    #endregion
	
	public Event()
	{
		this._Sprekers1 = new EntitySet<Spreker>(new Action<Spreker>(this.attach_Sprekers1), new Action<Spreker>(this.detach_Sprekers1));
		this._Aanwezigs = new EntitySet<Aanwezig>(new Action<Aanwezig>(this.attach_Aanwezigs), new Action<Aanwezig>(this.detach_Aanwezigs));
		this._Comments = new EntitySet<Comment>(new Action<Comment>(this.attach_Comments), new Action<Comment>(this.detach_Comments));
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_naam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string naam
	{
		get
		{
			return this._naam;
		}
		set
		{
			if ((this._naam != value))
			{
				this.OnnaamChanging(value);
				this.SendPropertyChanging();
				this._naam = value;
				this.SendPropertyChanged("naam");
				this.OnnaamChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_informatie", DbType="VarChar(200)")]
	public string informatie
	{
		get
		{
			return this._informatie;
		}
		set
		{
			if ((this._informatie != value))
			{
				this.OninformatieChanging(value);
				this.SendPropertyChanging();
				this._informatie = value;
				this.SendPropertyChanged("informatie");
				this.OninformatieChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datum", DbType="Date NOT NULL")]
	public System.DateTime datum
	{
		get
		{
			return this._datum;
		}
		set
		{
			if ((this._datum != value))
			{
				this.OndatumChanging(value);
				this.SendPropertyChanging();
				this._datum = value;
				this.SendPropertyChanged("datum");
				this.OndatumChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_visitors", DbType="Int")]
	public System.Nullable<int> visitors
	{
		get
		{
			return this._visitors;
		}
		set
		{
			if ((this._visitors != value))
			{
				this.OnvisitorsChanging(value);
				this.SendPropertyChanging();
				this._visitors = value;
				this.SendPropertyChanged("visitors");
				this.OnvisitorsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eigenaar", DbType="Int")]
	public System.Nullable<int> eigenaar
	{
		get
		{
			return this._eigenaar;
		}
		set
		{
			if ((this._eigenaar != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OneigenaarChanging(value);
				this.SendPropertyChanging();
				this._eigenaar = value;
				this.SendPropertyChanged("eigenaar");
				this.OneigenaarChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sprekers", DbType="NChar(10)")]
	public string sprekers
	{
		get
		{
			return this._sprekers;
		}
		set
		{
			if ((this._sprekers != value))
			{
				this.OnsprekersChanging(value);
				this.SendPropertyChanging();
				this._sprekers = value;
				this.SendPropertyChanged("sprekers");
				this.OnsprekersChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Spreker", Storage="_Sprekers1", ThisKey="Id", OtherKey="event_id")]
	public EntitySet<Spreker> Sprekers1
	{
		get
		{
			return this._Sprekers1;
		}
		set
		{
			this._Sprekers1.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Aanwezig", Storage="_Aanwezigs", ThisKey="Id", OtherKey="EventId")]
	public EntitySet<Aanwezig> Aanwezigs
	{
		get
		{
			return this._Aanwezigs;
		}
		set
		{
			this._Aanwezigs.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Comment", Storage="_Comments", ThisKey="Id", OtherKey="eventId")]
	public EntitySet<Comment> Comments
	{
		get
		{
			return this._Comments;
		}
		set
		{
			this._Comments.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Event", Storage="_User", ThisKey="eigenaar", OtherKey="Id", IsForeignKey=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.Events.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Events.Add(this);
					this._eigenaar = value.Id;
				}
				else
				{
					this._eigenaar = default(Nullable<int>);
				}
				this.SendPropertyChanged("User");
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
	
	private void attach_Sprekers1(Spreker entity)
	{
		this.SendPropertyChanging();
		entity.Event = this;
	}
	
	private void detach_Sprekers1(Spreker entity)
	{
		this.SendPropertyChanging();
		entity.Event = null;
	}
	
	private void attach_Aanwezigs(Aanwezig entity)
	{
		this.SendPropertyChanging();
		entity.Event = this;
	}
	
	private void detach_Aanwezigs(Aanwezig entity)
	{
		this.SendPropertyChanging();
		entity.Event = null;
	}
	
	private void attach_Comments(Comment entity)
	{
		this.SendPropertyChanging();
		entity.Event = this;
	}
	
	private void detach_Comments(Comment entity)
	{
		this.SendPropertyChanging();
		entity.Event = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Spreker")]
public partial class Spreker : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _naam;
	
	private string _begintijd;
	
	private int _event_id;
	
	private string _eindtijd;
	
	private EntityRef<Event> _Event;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnaamChanging(string value);
    partial void OnnaamChanged();
    partial void OnbegintijdChanging(string value);
    partial void OnbegintijdChanged();
    partial void Onevent_idChanging(int value);
    partial void Onevent_idChanged();
    partial void OneindtijdChanging(string value);
    partial void OneindtijdChanged();
    #endregion
	
	public Spreker()
	{
		this._Event = default(EntityRef<Event>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_naam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string naam
	{
		get
		{
			return this._naam;
		}
		set
		{
			if ((this._naam != value))
			{
				this.OnnaamChanging(value);
				this.SendPropertyChanging();
				this._naam = value;
				this.SendPropertyChanged("naam");
				this.OnnaamChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_begintijd", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
	public string begintijd
	{
		get
		{
			return this._begintijd;
		}
		set
		{
			if ((this._begintijd != value))
			{
				this.OnbegintijdChanging(value);
				this.SendPropertyChanging();
				this._begintijd = value;
				this.SendPropertyChanged("begintijd");
				this.OnbegintijdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_event_id", DbType="Int NOT NULL")]
	public int event_id
	{
		get
		{
			return this._event_id;
		}
		set
		{
			if ((this._event_id != value))
			{
				if (this._Event.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onevent_idChanging(value);
				this.SendPropertyChanging();
				this._event_id = value;
				this.SendPropertyChanged("event_id");
				this.Onevent_idChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eindtijd", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
	public string eindtijd
	{
		get
		{
			return this._eindtijd;
		}
		set
		{
			if ((this._eindtijd != value))
			{
				this.OneindtijdChanging(value);
				this.SendPropertyChanging();
				this._eindtijd = value;
				this.SendPropertyChanged("eindtijd");
				this.OneindtijdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Spreker", Storage="_Event", ThisKey="event_id", OtherKey="Id", IsForeignKey=true)]
	public Event Event
	{
		get
		{
			return this._Event.Entity;
		}
		set
		{
			Event previousValue = this._Event.Entity;
			if (((previousValue != value) 
						|| (this._Event.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Event.Entity = null;
					previousValue.Sprekers1.Remove(this);
				}
				this._Event.Entity = value;
				if ((value != null))
				{
					value.Sprekers1.Add(this);
					this._event_id = value.Id;
				}
				else
				{
					this._event_id = default(int);
				}
				this.SendPropertyChanged("Event");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Aanwezig")]
public partial class Aanwezig : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private int _EventId;
	
	private int _PersoonId;
	
	private string _qrcode;
	
	private EntityRef<Event> _Event;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEventIdChanging(int value);
    partial void OnEventIdChanged();
    partial void OnPersoonIdChanging(int value);
    partial void OnPersoonIdChanged();
    partial void OnqrcodeChanging(string value);
    partial void OnqrcodeChanged();
    #endregion
	
	public Aanwezig()
	{
		this._Event = default(EntityRef<Event>);
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventId", DbType="Int NOT NULL")]
	public int EventId
	{
		get
		{
			return this._EventId;
		}
		set
		{
			if ((this._EventId != value))
			{
				if (this._Event.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnEventIdChanging(value);
				this.SendPropertyChanging();
				this._EventId = value;
				this.SendPropertyChanged("EventId");
				this.OnEventIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersoonId", DbType="Int NOT NULL")]
	public int PersoonId
	{
		get
		{
			return this._PersoonId;
		}
		set
		{
			if ((this._PersoonId != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPersoonIdChanging(value);
				this.SendPropertyChanging();
				this._PersoonId = value;
				this.SendPropertyChanged("PersoonId");
				this.OnPersoonIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qrcode", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string qrcode
	{
		get
		{
			return this._qrcode;
		}
		set
		{
			if ((this._qrcode != value))
			{
				this.OnqrcodeChanging(value);
				this.SendPropertyChanging();
				this._qrcode = value;
				this.SendPropertyChanged("qrcode");
				this.OnqrcodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Aanwezig", Storage="_Event", ThisKey="EventId", OtherKey="Id", IsForeignKey=true)]
	public Event Event
	{
		get
		{
			return this._Event.Entity;
		}
		set
		{
			Event previousValue = this._Event.Entity;
			if (((previousValue != value) 
						|| (this._Event.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Event.Entity = null;
					previousValue.Aanwezigs.Remove(this);
				}
				this._Event.Entity = value;
				if ((value != null))
				{
					value.Aanwezigs.Add(this);
					this._EventId = value.Id;
				}
				else
				{
					this._EventId = default(int);
				}
				this.SendPropertyChanged("Event");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Aanwezig", Storage="_User", ThisKey="PersoonId", OtherKey="Id", IsForeignKey=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.Aanwezigs.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Aanwezigs.Add(this);
					this._PersoonId = value.Id;
				}
				else
				{
					this._PersoonId = default(int);
				}
				this.SendPropertyChanged("User");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comment")]
public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _commentTekst;
	
	private System.DateTime _datum;
	
	private int _persoonId;
	
	private int _eventId;
	
	private EntityRef<User> _User;
	
	private EntityRef<Event> _Event;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OncommentTekstChanging(string value);
    partial void OncommentTekstChanged();
    partial void OndatumChanging(System.DateTime value);
    partial void OndatumChanged();
    partial void OnpersoonIdChanging(int value);
    partial void OnpersoonIdChanged();
    partial void OneventIdChanging(int value);
    partial void OneventIdChanged();
    #endregion
	
	public Comment()
	{
		this._User = default(EntityRef<User>);
		this._Event = default(EntityRef<Event>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_commentTekst", DbType="VarChar(400) NOT NULL", CanBeNull=false)]
	public string commentTekst
	{
		get
		{
			return this._commentTekst;
		}
		set
		{
			if ((this._commentTekst != value))
			{
				this.OncommentTekstChanging(value);
				this.SendPropertyChanging();
				this._commentTekst = value;
				this.SendPropertyChanged("commentTekst");
				this.OncommentTekstChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datum", DbType="Date NOT NULL")]
	public System.DateTime datum
	{
		get
		{
			return this._datum;
		}
		set
		{
			if ((this._datum != value))
			{
				this.OndatumChanging(value);
				this.SendPropertyChanging();
				this._datum = value;
				this.SendPropertyChanged("datum");
				this.OndatumChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_persoonId", DbType="Int NOT NULL")]
	public int persoonId
	{
		get
		{
			return this._persoonId;
		}
		set
		{
			if ((this._persoonId != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnpersoonIdChanging(value);
				this.SendPropertyChanging();
				this._persoonId = value;
				this.SendPropertyChanged("persoonId");
				this.OnpersoonIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventId", DbType="Int NOT NULL")]
	public int eventId
	{
		get
		{
			return this._eventId;
		}
		set
		{
			if ((this._eventId != value))
			{
				if (this._Event.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OneventIdChanging(value);
				this.SendPropertyChanging();
				this._eventId = value;
				this.SendPropertyChanged("eventId");
				this.OneventIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Comment", Storage="_User", ThisKey="persoonId", OtherKey="Id", IsForeignKey=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.Comments.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Comments.Add(this);
					this._persoonId = value.Id;
				}
				else
				{
					this._persoonId = default(int);
				}
				this.SendPropertyChanged("User");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Comment", Storage="_Event", ThisKey="eventId", OtherKey="Id", IsForeignKey=true)]
	public Event Event
	{
		get
		{
			return this._Event.Entity;
		}
		set
		{
			Event previousValue = this._Event.Entity;
			if (((previousValue != value) 
						|| (this._Event.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Event.Entity = null;
					previousValue.Comments.Remove(this);
				}
				this._Event.Entity = value;
				if ((value != null))
				{
					value.Comments.Add(this);
					this._eventId = value.Id;
				}
				else
				{
					this._eventId = default(int);
				}
				this.SendPropertyChanged("Event");
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
#pragma warning restore 1591
