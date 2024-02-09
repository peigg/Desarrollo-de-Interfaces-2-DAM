
El proyecto tiene una portada, login, registro de usuario, un control de asistencia y un histórico.

Portada:

Muy sencilla, una imagen en un pictureBox y un botón.

Login: 

Proceso de login de usuario, con un vigilante y la opción de registrar otros usuarios.

Registro de Usuario:

Hay un formulario Register donde los usuarios pueden ingresar información como nombre, apellido, correo electrónico, número de teléfono, fecha de nacimiento, nombre de usuario y contraseña.
Implementas validaciones para asegurarte de que la información ingresada sea correcta.

Seguridad de Contraseña:

He implementado una capa de seguridad para almacenar las contraseñas de los usuarios de manera más segura. Utilizas un algoritmo de hash (SHA-256) con un salt generado aleatoriamente.

Persistencia de Datos:

Guardo la información del usuario, incluidas la información sensible y las preferencias, en la configuración de la aplicación (Properties.Settings.Default).


Mejoras y Problemas Actuales:

Falta gran parte de la lógica del control de asistencia y el histórico, así como mejorar sus UIs.

Interfaz de Usuario (UI):

Utilizo Windows Forms para la interfaz de usuario,  agregué funcionalidades como mostrar/ocultar caracteres de contraseña.
Clases Adicionales:

Tengo clases adicionales como SecurityHash para manejar funciones relacionadas con la seguridad, y Vigilante para manejar el registro y autenticación de usuarios.
