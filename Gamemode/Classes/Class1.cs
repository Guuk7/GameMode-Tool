using System;
using System.Diagnostics;
using System.IO;

namespace Gamemode.Classes
{
    public static class SystemCommands
    {
        public static void KillExplorer()
        {
            try
            {
                Process.Start("taskkill", "/f /im explorer.exe");
            }
            catch (Exception ex)
            {
                // Adiciona um log para melhor rastreamento de erros
                LogError("Erro ao tentar fechar o explorer.exe", ex);
                throw new ApplicationException("Erro ao tentar fechar o explorer.exe", ex);
            }
        }

        public static void StartTaskManager()
        {
            try
            {
                Process.Start("taskmgr.exe");
            }
            catch (Exception ex)
            {
                // Adiciona um log para melhor rastreamento de erros
                LogError("Erro ao reiniciar o explorer.exe e abrir o Gerenciador de Tarefas", ex);
                throw new ApplicationException("Erro ao reiniciar o explorer.exe e abrir o Gerenciador de Tarefas", ex);
            }
        }

        public static void DisableIdle()
        {
            try
            {
                Process.Start("cmd.exe", "/c powercfg /setacvalueindex scheme_current sub_processor 5d76a2ca-e8c0-402f-a133-2158492d58ad 1 && powercfg /setactive scheme_current");
            }
            catch (Exception ex)
            {
                // Adiciona um log para melhor rastreamento de erros
                LogError("Erro ao tentar desativar o modo de espera", ex);
                throw new ApplicationException("Erro ao tentar desativar o modo de espera", ex);
            }
        }

        public static void EnableIdle()
        {
            try
            {
                Process.Start("cmd.exe", "/c powercfg /setacvalueindex scheme_current sub_processor 5d76a2ca-e8c0-402f-a133-2158492d58ad 0 && powercfg /setactive scheme_current");
            }
            catch (Exception ex)
            {
                // Adiciona um log para melhor rastreamento de erros
                LogError("Erro ao tentar ativar o modo de espera", ex);
                throw new ApplicationException("Erro ao tentar ativar o modo de espera", ex);
            }
        }

        // Método adicional para registrar erros em um arquivo de log
        private static void LogError(string message, Exception ex)
        {
            try
            {
                File.AppendAllText("error_log.txt", $"{DateTime.Now}: {message} - {ex.Message}{Environment.NewLine}");
            }
            catch
            {
                // Se falhar ao gravar o log, evitará lançar uma exceção adicional
            }
        }
    }
}
