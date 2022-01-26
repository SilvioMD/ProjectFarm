Imports Capa_de_Seguridad
Module MdlSalir

    Public Sub Salir()

        'eliminar datos de usuario
        CacheDatosUsuario.Usuario = ""
        CacheDatosUsuario.Nombres = ""
        CacheDatosUsuario.Apellidos = ""
        CacheDatosUsuario.Rol = 0

        'Cerrar aplicacion
        Application.Exit()

    End Sub

End Module
