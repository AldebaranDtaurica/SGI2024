namespace CapaServicios
{
    public static class CSR_ArmarMail
    {
        public static string DireccionCorreo { get; set; }
        public static string Asunto { get; set; }
        public static string NuevaContraseña { get; set; }

        public static void Preparar()
        {
            string body = $@"<style>
                            h1{{color:dodgerblue;}}
                            h2{{color:darkorange;}}
                            </style>
                            <p>¡Hola!</span></p>
                            <p>Se ha realizado el alta de usuario, será informado por la institución.</p></br></br>
                            <h1>Contraseña para su primer ingreso.</h1></br>
                            <h2>Clave de Ingreso: {NuevaContraseña}</h2></br></br>
                            <h3>Si este mail no fue solicitado por usted desestímelo.</h3></br></br></br></br>
                            <h4>Gracias por utilizar nuestros servicios.<h4></br></br>
                            <h5>Este mensaje es generado automáticamente, por favor no responda.<h5></br></br></br>
                            <p>Sistema de Gestión Institucional © 2024.</p>";

            CSR_EnviarMail.sendMail(DireccionCorreo, Asunto, body);
        }

        public static void PrepararRec()
        {
            string body = $@"<style>
                            h1{{color:dodgerblue;}}
                            h2{{color:darkorange;}}
                            </style>
                            <p>¡Hola!</span></p>
                            <p>Se ha solicitado la recuperación de contraseña para su usuario.</p></br></br>
                            <h1>Recuperación de contraseña.</h1></br>
                            <h2>Clave de Ingreso: {NuevaContraseña}</h2></br></br>
                            <h3>Si este mail no fue solicitado por usted desestímelo.</h3></br></br></br></br>
                            <h4>Gracias por utilizar nuestros servicios.</h4></br></br>
                            <h5>Este mensaje es generado automáticamente, por favor no responda.</h5></br></br></br>
                            <p>Sistema de Gestión Institucional © 2024.</p>";

            CSR_EnviarMail.sendMail(DireccionCorreo, Asunto, body);
        }
    }
}