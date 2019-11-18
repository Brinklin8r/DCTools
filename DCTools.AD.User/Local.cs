using System;


namespace DCTools.User {
    public class Local {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public enum Environment {
            CUCBIP,
            CUCBECM,
            CUCBInf,
            Digital,
            LFI
        }
        
        public void Add(string UserName, Environment Env) {
            Logger.Debug("Add User {0} to {1}.", UserName, Env);
        }

        public void Add(string UserName, Environment Env, bool CAT) {
            Logger.Debug("Add CAT User {0} to {1}.", UserName, Env);
        }

        public void Delete(string UserName) {
            Logger.Debug("Delete User {0} to {1}.", UserName);
        }

        public void Delete(string UserName, bool CAT) {
            Logger.Debug("Delete CAT User {0} to {1}.", UserName);
        }
    }




}
