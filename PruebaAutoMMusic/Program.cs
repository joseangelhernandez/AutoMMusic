using PruebaAutoMMusic.ObjectRepository;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;

string URL = "https://open.spotify.com/";
string email = "kevinjrosario05@gmail.com";
string pass = "Principito0102";

// Obtiene la ruta del directorio del ejecutable
string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
// Combina la ruta del directorio del ejecutable con el nombre del archivo
string filePath = Path.Combine(baseDirectory, "config.txt");

try
{
    // Lee todas las líneas del archivo
    string[] lines = File.ReadAllLines(filePath);

    // Asume que el archivo tiene al menos 3 líneas
    email = lines[0];
    pass = lines[1];

    // Muestra los valores para verificar que se leyeron correctamente
    Console.WriteLine($"Email: {email}");
    Console.WriteLine($"Password: {pass}");
}
catch (IOException e)
{
    // Maneja el error si el archivo no se puede leer
    Console.WriteLine($"No se pudo leer el archivo: {e.Message}");
}


Console.WriteLine("PRESIONE CUALQUIER TECLA PARA EMPEZAR...");
Console.ReadKey();

Console.WriteLine("AUTOMATIZACION EN CURSO");
WebDriver driver = new ChromeDriver();

Console.WriteLine("Logeando");
driver.Navigate().GoToUrl(URL);

IngresarUsuario(driver, email, pass);

static void IngresarUsuario(WebDriver driver, string value, string pas)
{
        driver.FindElement(LoginObjects.button_Entrar).Click();
        Thread.Sleep(3000);
        driver.FindElement(LoginObjects.input_Usuario).SendKeys(value);
        driver.FindElement(LoginObjects.input_Clave).SendKeys(pas);
        driver.FindElement(LoginObjects.login).Click();

        while (true)
        {


            if (true)
            {
                // Aquí colocas el código para ejecutar tu flujo en Selenium
                // por ejemplo, llama a tu método que contiene el flujo
                ReproducirPlaylist(driver);
                Console.WriteLine("Flujo ejecutado con éxito.");

                // Esperar 2 horas antes de ejecutar nuevamente
                Thread.Sleep(20000);
            }
            else
            {
                //Console.WriteLine($"Error al ejecutar el flujo: {ex.Message}");
                IngresarUsuario(driver, value, pas);
                // En caso de error, puedes ajustar el tiempo de espera o manejar la situación según tus necesidades
                Thread.Sleep(10000); // Esperar 2 minutos antes de intentar nuevamente en caso de error
            }
        }

}

static void ReproducirPlaylist(WebDriver driver)
{
    Thread.Sleep(4000);
    driver.FindElement(LoginObjects.Buscar).Click();
    Thread.Sleep(3000);
    driver.FindElement(LoginObjects.BuscarInput).SendKeys("VmSongsFanSad");
    Thread.Sleep(3000);
    driver.FindElement(LoginObjects.tabPlaylist).Click();
    Thread.Sleep(3000);
    driver.FindElement(LoginObjects.irPlaylist).Click();
    Thread.Sleep(3000);
    driver.FindElement(LoginObjects.reproducir).Click();
    Thread.Sleep(2000);
    new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(d => d.FindElement(LoginObjects.siguiente).Displayed);
    driver.FindElement(LoginObjects.siguiente).Click();

    Thread.Sleep(10000);
    driver.FindElement(LoginObjects.Buscar).Click();
    Thread.Sleep(3000);
    Random rnd = new Random();
    List<string> correos = new List<string>() { "luiyitox me lo como", "luiyitox  no la presumas", "luiyitox   de que me vale negarlo" };
    int correosIndex = rnd.Next(correos.Count);
    string correosrandom = Convert.ToString(correos[correosIndex]);
    driver.FindElement(LoginObjects.BuscarInput).SendKeys(correosrandom);
    Thread.Sleep(3000);
    driver.FindElement(LoginObjects.reproducirAleatorio).Click();
    Thread.Sleep(3000);
    driver.FindElement(LoginObjects.reproducirmusicAleatorio).Click();
    Thread.Sleep(3000);
    driver.FindElement(LoginObjects.reproducirRAND).Click();
}
static void correr(WebDriver driver, string value, string pas)
{
    while (true)
    {


        if (true)
        {
            // Aquí colocas el código para ejecutar tu flujo en Selenium
            // por ejemplo, llama a tu método que contiene el flujo
            IngresarUsuario(driver, value, pas);

            Console.WriteLine("Flujo ejecutado con éxito.");

            // Esperar 2 horas antes de ejecutar nuevamente
            Thread.Sleep(10000);
        }
        else
        {
            //Console.WriteLine($"Error al ejecutar el flujo: {ex.Message}");
            IngresarUsuario(driver, value, pas);
            // En caso de error, puedes ajustar el tiempo de espera o manejar la situación según tus necesidades
            Thread.Sleep(10000); // Esperar 2 minutos antes de intentar nuevamente en caso de error
        }
    }


}