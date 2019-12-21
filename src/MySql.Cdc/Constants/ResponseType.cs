namespace MySql.Cdc.Constants
{
    public enum ResponseType
    {
        Ok = 0x00,
        Error = 0xFF,
        EndOfFile = 0xFE,
        AuthPluginSwitch = 0xFE,
    }
}
