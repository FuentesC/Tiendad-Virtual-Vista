﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.AccesoDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TiendaVirtualVista")]
	public partial class conexionLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public conexionLinqDataContext() :
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TiendaVirtualVistaConnectionString7"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertarUsuario")]
		public int InsertarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellidos", DbType="VarChar(50)")] string apellidos, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad", DbType="Int")] System.Nullable<int> edad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreUsuario", DbType="VarChar(50)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CorreoElectronico", DbType="VarChar(100)")] string correoElectronico, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(100)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RolID", DbType="Int")] System.Nullable<int> rolID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apellidos, edad, nombreUsuario, correoElectronico, contraseña, rolID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ActualizarUsuario")]
		public int ActualizarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellidos", DbType="VarChar(50)")] string apellidos, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Edad", DbType="Int")] System.Nullable<int> edad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreUsuario", DbType="VarChar(50)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CorreoElectronico", DbType="VarChar(100)")] string correoElectronico, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(100)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RolID", DbType="Int")] System.Nullable<int> rolID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID, nombre, apellidos, edad, nombreUsuario, correoElectronico, contraseña, rolID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarUsuario")]
		public int EliminarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.pa_Login")]
		public ISingleResult<pa_LoginResult> pa_Login([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreUsuario", DbType="VarChar(50)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contraseña", DbType="VarChar(100)")] string contraseña)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreUsuario, contraseña);
			return ((ISingleResult<pa_LoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarJuegoAlCarrito")]
		public int AgregarJuegoAlCarrito([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="JuegoID", DbType="Int")] System.Nullable<int> juegoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID, juegoID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BuscarJuegoPorID")]
		public ISingleResult<BuscarJuegoPorIDResult> BuscarJuegoPorID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="JuegoID", DbType="Int")] System.Nullable<int> juegoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), juegoID);
			return ((ISingleResult<BuscarJuegoPorIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarJuegoDeWishlist")]
		public int EliminarJuegoDeWishlist([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="JuegoID", DbType="Int")] System.Nullable<int> juegoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID, juegoID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ObtenerBibliotecaDeUsuario")]
		public ISingleResult<ObtenerBibliotecaDeUsuarioResult> ObtenerBibliotecaDeUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID);
			return ((ISingleResult<ObtenerBibliotecaDeUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ObtenerListaJuegos")]
		public ISingleResult<ObtenerListaJuegosResult> ObtenerListaJuegos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ObtenerListaJuegosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ObtenerWishlistDeUsuario")]
		public ISingleResult<ObtenerWishlistDeUsuarioResult> ObtenerWishlistDeUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID);
			return ((ISingleResult<ObtenerWishlistDeUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ObtenerListaUsuarios")]
		public ISingleResult<ObtenerListaUsuariosResult> ObtenerListaUsuarios()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ObtenerListaUsuariosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ObtenerUsuario")]
		public ISingleResult<ObtenerUsuarioResult> ObtenerUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID);
			return ((ISingleResult<ObtenerUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarResena")]
		public int AgregarResena([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="JuegoID", DbType="Int")] System.Nullable<int> juegoID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Comentario", DbType="Text")] string comentario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID, juegoID, comentario);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ObtenerResenas")]
		public ISingleResult<ObtenerResenasResult> ObtenerResenas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> juegoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), juegoID);
			return ((ISingleResult<ObtenerResenasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AceptarSolicitud")]
		public int AceptarSolicitud([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SolicitudID", DbType="Int")] System.Nullable<int> solicitudID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), solicitudID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EnviarSolicitud")]
		public int EnviarSolicitud([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID1", DbType="Int")] System.Nullable<int> usuarioID1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID2", DbType="Int")] System.Nullable<int> usuarioID2)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID1, usuarioID2);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ValidarCodigo")]
		public ISingleResult<ValidarCodigoResult> ValidarCodigo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="VarChar(50)")] string codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo);
			return ((ISingleResult<ValidarCodigoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AgregarJuegoAWishlist")]
		public int AgregarJuegoAWishlist([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="JuegoID", DbType="Int")] System.Nullable<int> juegoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID, juegoID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ComprarJuego")]
		public int ComprarJuego([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CarritoID", DbType="Int")] System.Nullable<int> carritoID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CodigoID", DbType="Int")] System.Nullable<int> codigoID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), carritoID, codigoID);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class pa_LoginResult
	{
		
		private int _UsuarioID;
		
		private string _NombreUsuario;
		
		private string _Contraseña;
		
		public pa_LoginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", DbType="Int NOT NULL")]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this._UsuarioID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUsuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreUsuario
		{
			get
			{
				return this._NombreUsuario;
			}
			set
			{
				if ((this._NombreUsuario != value))
				{
					this._NombreUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this._Contraseña = value;
				}
			}
		}
	}
	
	public partial class BuscarJuegoPorIDResult
	{
		
		private int _JuegoID;
		
		private string _Desarrollador;
		
		private string _Genero;
		
		private decimal _Precio;
		
		private System.DateTime _FechaLanzamiento;
		
		private string _Descripcion;
		
		public BuscarJuegoPorIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JuegoID", DbType="Int NOT NULL")]
		public int JuegoID
		{
			get
			{
				return this._JuegoID;
			}
			set
			{
				if ((this._JuegoID != value))
				{
					this._JuegoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desarrollador", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Desarrollador
		{
			get
			{
				return this._Desarrollador;
			}
			set
			{
				if ((this._Desarrollador != value))
				{
					this._Desarrollador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(10,2) NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaLanzamiento", DbType="Date NOT NULL")]
		public System.DateTime FechaLanzamiento
		{
			get
			{
				return this._FechaLanzamiento;
			}
			set
			{
				if ((this._FechaLanzamiento != value))
				{
					this._FechaLanzamiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class ObtenerBibliotecaDeUsuarioResult
	{
		
		private int _JuegoID;
		
		private string _Desarrollador;
		
		private string _Genero;
		
		private decimal _Precio;
		
		private System.DateTime _FechaLanzamiento;
		
		private string _Descripcion;
		
		public ObtenerBibliotecaDeUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JuegoID", DbType="Int NOT NULL")]
		public int JuegoID
		{
			get
			{
				return this._JuegoID;
			}
			set
			{
				if ((this._JuegoID != value))
				{
					this._JuegoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desarrollador", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Desarrollador
		{
			get
			{
				return this._Desarrollador;
			}
			set
			{
				if ((this._Desarrollador != value))
				{
					this._Desarrollador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(10,2) NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaLanzamiento", DbType="Date NOT NULL")]
		public System.DateTime FechaLanzamiento
		{
			get
			{
				return this._FechaLanzamiento;
			}
			set
			{
				if ((this._FechaLanzamiento != value))
				{
					this._FechaLanzamiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class ObtenerListaJuegosResult
	{
		
		private int _JuegoID;
		
		private string _Desarrollador;
		
		private string _Genero;
		
		private decimal _Precio;
		
		private System.DateTime _FechaLanzamiento;
		
		private string _Descripcion;
		
		public ObtenerListaJuegosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JuegoID", DbType="Int NOT NULL")]
		public int JuegoID
		{
			get
			{
				return this._JuegoID;
			}
			set
			{
				if ((this._JuegoID != value))
				{
					this._JuegoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desarrollador", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Desarrollador
		{
			get
			{
				return this._Desarrollador;
			}
			set
			{
				if ((this._Desarrollador != value))
				{
					this._Desarrollador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(10,2) NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaLanzamiento", DbType="Date NOT NULL")]
		public System.DateTime FechaLanzamiento
		{
			get
			{
				return this._FechaLanzamiento;
			}
			set
			{
				if ((this._FechaLanzamiento != value))
				{
					this._FechaLanzamiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class ObtenerWishlistDeUsuarioResult
	{
		
		private int _JuegoID;
		
		private string _Desarrollador;
		
		private string _Genero;
		
		private decimal _Precio;
		
		private System.DateTime _FechaLanzamiento;
		
		private string _Descripcion;
		
		public ObtenerWishlistDeUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JuegoID", DbType="Int NOT NULL")]
		public int JuegoID
		{
			get
			{
				return this._JuegoID;
			}
			set
			{
				if ((this._JuegoID != value))
				{
					this._JuegoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desarrollador", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Desarrollador
		{
			get
			{
				return this._Desarrollador;
			}
			set
			{
				if ((this._Desarrollador != value))
				{
					this._Desarrollador = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Decimal(10,2) NOT NULL")]
		public decimal Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this._Precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaLanzamiento", DbType="Date NOT NULL")]
		public System.DateTime FechaLanzamiento
		{
			get
			{
				return this._FechaLanzamiento;
			}
			set
			{
				if ((this._FechaLanzamiento != value))
				{
					this._FechaLanzamiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class ObtenerListaUsuariosResult
	{
		
		private int _UsuarioID;
		
		private string _Nombre;
		
		private string _Apellidos;
		
		private int _Edad;
		
		private string _NombreUsuario;
		
		private string _CorreoElectronico;
		
		private string _Contrasena;
		
		private System.DateTime _FechaRegistro;
		
		private int _RolID;
		
		public ObtenerListaUsuariosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", DbType="Int NOT NULL")]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this._UsuarioID = value;
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this._Apellidos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edad", DbType="Int NOT NULL")]
		public int Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				if ((this._Edad != value))
				{
					this._Edad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUsuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreUsuario
		{
			get
			{
				return this._NombreUsuario;
			}
			set
			{
				if ((this._NombreUsuario != value))
				{
					this._NombreUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoElectronico", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string CorreoElectronico
		{
			get
			{
				return this._CorreoElectronico;
			}
			set
			{
				if ((this._CorreoElectronico != value))
				{
					this._CorreoElectronico = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasena", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Contrasena
		{
			get
			{
				return this._Contrasena;
			}
			set
			{
				if ((this._Contrasena != value))
				{
					this._Contrasena = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="DateTime NOT NULL")]
		public System.DateTime FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this._FechaRegistro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					this._RolID = value;
				}
			}
		}
	}
	
	public partial class ObtenerUsuarioResult
	{
		
		private int _UsuarioID;
		
		private string _Nombre;
		
		private string _Apellidos;
		
		private int _Edad;
		
		private string _NombreUsuario;
		
		private string _CorreoElectronico;
		
		private string _Contrasena;
		
		private System.DateTime _FechaRegistro;
		
		private int _RolID;
		
		public ObtenerUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", DbType="Int NOT NULL")]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this._UsuarioID = value;
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this._Apellidos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edad", DbType="Int NOT NULL")]
		public int Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				if ((this._Edad != value))
				{
					this._Edad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUsuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreUsuario
		{
			get
			{
				return this._NombreUsuario;
			}
			set
			{
				if ((this._NombreUsuario != value))
				{
					this._NombreUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoElectronico", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string CorreoElectronico
		{
			get
			{
				return this._CorreoElectronico;
			}
			set
			{
				if ((this._CorreoElectronico != value))
				{
					this._CorreoElectronico = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasena", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Contrasena
		{
			get
			{
				return this._Contrasena;
			}
			set
			{
				if ((this._Contrasena != value))
				{
					this._Contrasena = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="DateTime NOT NULL")]
		public System.DateTime FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this._FechaRegistro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					this._RolID = value;
				}
			}
		}
	}
	
	public partial class ObtenerResenasResult
	{
		
		private int _UsuarioID;
		
		private int _JuegoID;
		
		private string _Comentario;
		
		private System.Nullable<System.DateTime> _FechaReseña;
		
		public ObtenerResenasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", DbType="Int NOT NULL")]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this._UsuarioID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JuegoID", DbType="Int NOT NULL")]
		public int JuegoID
		{
			get
			{
				return this._JuegoID;
			}
			set
			{
				if ((this._JuegoID != value))
				{
					this._JuegoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comentario", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Comentario
		{
			get
			{
				return this._Comentario;
			}
			set
			{
				if ((this._Comentario != value))
				{
					this._Comentario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaReseña", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaReseña
		{
			get
			{
				return this._FechaReseña;
			}
			set
			{
				if ((this._FechaReseña != value))
				{
					this._FechaReseña = value;
				}
			}
		}
	}
	
	public partial class ValidarCodigoResult
	{
		
		private int _CodigoID;
		
		private string _Codigo;
		
		private System.Nullable<decimal> _Descuento;
		
		public ValidarCodigoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoID", DbType="Int NOT NULL")]
		public int CodigoID
		{
			get
			{
				return this._CodigoID;
			}
			set
			{
				if ((this._CodigoID != value))
				{
					this._CodigoID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="VarChar(50)")]
		public string Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descuento", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Descuento
		{
			get
			{
				return this._Descuento;
			}
			set
			{
				if ((this._Descuento != value))
				{
					this._Descuento = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
