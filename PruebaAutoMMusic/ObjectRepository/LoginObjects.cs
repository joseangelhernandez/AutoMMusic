using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAutoMMusic.ObjectRepository
{
    public class LoginObjects
    {
        public static By input_Usuario = By.XPath("//*[@id='login-username']");
        public static By input_Clave = By.XPath("//*[@id='login-password']");
        public static By button_Entrar = By.XPath("//*[@id='main']/div/div[2]/div[3]/header/div[4]/div[1]/button[2]");
        public static By login = By.XPath("//*[@id='login-button']");
        public static By Buscar = By.XPath("//*[@id='main']/div/div[2]/div[1]/nav/div[1]/ul/li[2]/a");
        public static By BuscarInput = By.XPath("//*[@id='main']/div/div[2]/div[3]/header/div[3]/div/div/form/input");
        public static By tabPlaylist = By.XPath("//*[@id='main']/div/div[2]/div[3]/div[1]/div[2]/div[2]/div/div/div[2]/main/div[1]/div/div/div/div/div/a[2]");
        public static By irPlaylist = By.XPath("//*[@id='searchPage']/div/div/div/div[1]/div[1]");
        public static By reproducir = By.XPath("//*[@id='main']/div/div[2]/div[3]/div[1]/div[2]/div[2]/div/div/div[2]/main/div[1]/section/div[2]/div[2]/div[4]/div/div/div/div/div[1]/button");
        public static By reproducirAleatorio = By.XPath("//*[@id='main']/div/div[2]/div[3]/div[1]/div[2]/div[2]/div/div/div[2]/main/div[1]/div/div/div/div/div/a[3]/button");
        public static By reproducirRAND = By.XPath("//*[@id='main']/div/div[2]/div[3]/div[1]/div[2]/div[2]/div/div/div[2]/main/section/div[3]/div[4]/div/div/div/div/div[1]/button");
        public static By reproducirmusicAleatorio = By.XPath("//*[@id='searchPage']/div/div/div/div[1]/div[1]/div[1]");
        public static By UnaSola = By.XPath("//button[@class='Vz6yjzttS0YlLcwrkoUR tP0mccyU1WAa7I9PevC1'][@aria-checked='mixed']");
        public static By Todas = By.XPath("//button[@class='Vz6yjzttS0YlLcwrkoUR tP0mccyU1WAa7I9PevC1']");
        public static By busrarRandom = By.XPath("//button[@class='Vz6yjzttS0YlLcwrkoUR']");
        public static By siguiente = By.XPath("//*[@id='main']/div/div[2]/div[2]/footer/div/div[2]/div/div[1]/div[2]/button[1]");
    }
}
