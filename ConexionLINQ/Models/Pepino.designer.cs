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

namespace ConexionLINQ.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PepinoDB")]
	public partial class PepinoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAgricultor(Agricultor instance);
    partial void UpdateAgricultor(Agricultor instance);
    partial void DeleteAgricultor(Agricultor instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertPepinoUsuario(PepinoUsuario instance);
    partial void UpdatePepinoUsuario(PepinoUsuario instance);
    partial void DeletePepinoUsuario(PepinoUsuario instance);
    partial void InsertPepino(Pepino instance);
    partial void UpdatePepino(Pepino instance);
    partial void DeletePepino(Pepino instance);
    #endregion
		
		public PepinoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["PepinoDBConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PepinoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PepinoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PepinoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PepinoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Agricultor> Agricultors
		{
			get
			{
				return this.GetTable<Agricultor>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuarios
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<PepinoUsuario> PepinoUsuarios
		{
			get
			{
				return this.GetTable<PepinoUsuario>();
			}
		}
		
		public System.Data.Linq.Table<Pepino> Pepinos
		{
			get
			{
				return this.GetTable<Pepino>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Agricultor")]
	public partial class Agricultor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Población;
		
		private string _CP;
		
		private EntitySet<Pepino> _Pepinos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnPoblaciónChanging(string value);
    partial void OnPoblaciónChanged();
    partial void OnCPChanging(string value);
    partial void OnCPChanged();
    #endregion
		
		public Agricultor()
		{
			this._Pepinos = new EntitySet<Pepino>(new Action<Pepino>(this.attach_Pepinos), new Action<Pepino>(this.detach_Pepinos));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Población", DbType="NVarChar(50)")]
		public string Población
		{
			get
			{
				return this._Población;
			}
			set
			{
				if ((this._Población != value))
				{
					this.OnPoblaciónChanging(value);
					this.SendPropertyChanging();
					this._Población = value;
					this.SendPropertyChanged("Población");
					this.OnPoblaciónChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CP", DbType="NVarChar(50)")]
		public string CP
		{
			get
			{
				return this._CP;
			}
			set
			{
				if ((this._CP != value))
				{
					this.OnCPChanging(value);
					this.SendPropertyChanging();
					this._CP = value;
					this.SendPropertyChanged("CP");
					this.OnCPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Agricultor_Pepino", Storage="_Pepinos", ThisKey="Id", OtherKey="AgricultorId")]
		public EntitySet<Pepino> Pepinos
		{
			get
			{
				return this._Pepinos;
			}
			set
			{
				this._Pepinos.Assign(value);
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
		
		private void attach_Pepinos(Pepino entity)
		{
			this.SendPropertyChanging();
			entity.Agricultor = this;
		}
		
		private void detach_Pepinos(Pepino entity)
		{
			this.SendPropertyChanging();
			entity.Agricultor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Email;
		
		private string _Nickname;
		
		private string _Password;
		
		private EntitySet<PepinoUsuario> _PepinoUsuarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnNicknameChanging(string value);
    partial void OnNicknameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Usuario()
		{
			this._PepinoUsuarios = new EntitySet<PepinoUsuario>(new Action<PepinoUsuario>(this.attach_PepinoUsuarios), new Action<PepinoUsuario>(this.detach_PepinoUsuarios));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nickname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nickname
		{
			get
			{
				return this._Nickname;
			}
			set
			{
				if ((this._Nickname != value))
				{
					this.OnNicknameChanging(value);
					this.SendPropertyChanging();
					this._Nickname = value;
					this.SendPropertyChanged("Nickname");
					this.OnNicknameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_PepinoUsuario", Storage="_PepinoUsuarios", ThisKey="Id", OtherKey="UsuarioId")]
		public EntitySet<PepinoUsuario> PepinoUsuarios
		{
			get
			{
				return this._PepinoUsuarios;
			}
			set
			{
				this._PepinoUsuarios.Assign(value);
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
		
		private void attach_PepinoUsuarios(PepinoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_PepinoUsuarios(PepinoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PepinoUsuario")]
	public partial class PepinoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PepinoId;
		
		private int _UsuarioId;
		
		private EntityRef<Usuario> _Usuario;
		
		private EntityRef<Pepino> _Pepino;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPepinoIdChanging(int value);
    partial void OnPepinoIdChanged();
    partial void OnUsuarioIdChanging(int value);
    partial void OnUsuarioIdChanged();
    #endregion
		
		public PepinoUsuario()
		{
			this._Usuario = default(EntityRef<Usuario>);
			this._Pepino = default(EntityRef<Pepino>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PepinoId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PepinoId
		{
			get
			{
				return this._PepinoId;
			}
			set
			{
				if ((this._PepinoId != value))
				{
					if (this._Pepino.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPepinoIdChanging(value);
					this.SendPropertyChanging();
					this._PepinoId = value;
					this.SendPropertyChanged("PepinoId");
					this.OnPepinoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UsuarioId
		{
			get
			{
				return this._UsuarioId;
			}
			set
			{
				if ((this._UsuarioId != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsuarioIdChanging(value);
					this.SendPropertyChanging();
					this._UsuarioId = value;
					this.SendPropertyChanged("UsuarioId");
					this.OnUsuarioIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_PepinoUsuario", Storage="_Usuario", ThisKey="UsuarioId", OtherKey="Id", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.PepinoUsuarios.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.PepinoUsuarios.Add(this);
						this._UsuarioId = value.Id;
					}
					else
					{
						this._UsuarioId = default(int);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pepino_PepinoUsuario", Storage="_Pepino", ThisKey="PepinoId", OtherKey="Id", IsForeignKey=true)]
		public Pepino Pepino
		{
			get
			{
				return this._Pepino.Entity;
			}
			set
			{
				Pepino previousValue = this._Pepino.Entity;
				if (((previousValue != value) 
							|| (this._Pepino.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pepino.Entity = null;
						previousValue.PepinoUsuarios.Remove(this);
					}
					this._Pepino.Entity = value;
					if ((value != null))
					{
						value.PepinoUsuarios.Add(this);
						this._PepinoId = value.Id;
					}
					else
					{
						this._PepinoId = default(int);
					}
					this.SendPropertyChanged("Pepino");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pepino")]
	public partial class Pepino : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private decimal _Longitud;
		
		private decimal _Peso;
		
		private int _AgricultorId;
		
		private EntitySet<PepinoUsuario> _PepinoUsuarios;
		
		private EntityRef<Agricultor> _Agricultor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnLongitudChanging(decimal value);
    partial void OnLongitudChanged();
    partial void OnPesoChanging(decimal value);
    partial void OnPesoChanged();
    partial void OnAgricultorIdChanging(int value);
    partial void OnAgricultorIdChanged();
    #endregion
		
		public Pepino()
		{
			this._PepinoUsuarios = new EntitySet<PepinoUsuario>(new Action<PepinoUsuario>(this.attach_PepinoUsuarios), new Action<PepinoUsuario>(this.detach_PepinoUsuarios));
			this._Agricultor = default(EntityRef<Agricultor>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitud", DbType="Decimal(18,0) NOT NULL")]
		public decimal Longitud
		{
			get
			{
				return this._Longitud;
			}
			set
			{
				if ((this._Longitud != value))
				{
					this.OnLongitudChanging(value);
					this.SendPropertyChanging();
					this._Longitud = value;
					this.SendPropertyChanged("Longitud");
					this.OnLongitudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Peso", DbType="Decimal(18,0) NOT NULL")]
		public decimal Peso
		{
			get
			{
				return this._Peso;
			}
			set
			{
				if ((this._Peso != value))
				{
					this.OnPesoChanging(value);
					this.SendPropertyChanging();
					this._Peso = value;
					this.SendPropertyChanged("Peso");
					this.OnPesoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgricultorId", DbType="Int NOT NULL")]
		public int AgricultorId
		{
			get
			{
				return this._AgricultorId;
			}
			set
			{
				if ((this._AgricultorId != value))
				{
					if (this._Agricultor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAgricultorIdChanging(value);
					this.SendPropertyChanging();
					this._AgricultorId = value;
					this.SendPropertyChanged("AgricultorId");
					this.OnAgricultorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pepino_PepinoUsuario", Storage="_PepinoUsuarios", ThisKey="Id", OtherKey="PepinoId")]
		public EntitySet<PepinoUsuario> PepinoUsuarios
		{
			get
			{
				return this._PepinoUsuarios;
			}
			set
			{
				this._PepinoUsuarios.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Agricultor_Pepino", Storage="_Agricultor", ThisKey="AgricultorId", OtherKey="Id", IsForeignKey=true)]
		public Agricultor Agricultor
		{
			get
			{
				return this._Agricultor.Entity;
			}
			set
			{
				Agricultor previousValue = this._Agricultor.Entity;
				if (((previousValue != value) 
							|| (this._Agricultor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Agricultor.Entity = null;
						previousValue.Pepinos.Remove(this);
					}
					this._Agricultor.Entity = value;
					if ((value != null))
					{
						value.Pepinos.Add(this);
						this._AgricultorId = value.Id;
					}
					else
					{
						this._AgricultorId = default(int);
					}
					this.SendPropertyChanged("Agricultor");
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
		
		private void attach_PepinoUsuarios(PepinoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Pepino = this;
		}
		
		private void detach_PepinoUsuarios(PepinoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Pepino = null;
		}
	}
}
#pragma warning restore 1591
