CREATE TABLE [dbo].[SalxCli] (
    [CodigoCliente]  INT           NULL,
    [Nombres]        NVARCHAR (50) NULL,
    [Apellidos]      NVARCHAR (50) NULL,
    [TotalCreditos]  FLOAT (53)    NULL,
    [TotalAbonos]    FLOAT (53)    NULL,
    [Saldo]          FLOAT (53)    NULL,
    [SSMA_TimeStamp] ROWVERSION    NOT NULL,
    CONSTRAINT [SSMA_CC$SalxCli$Apellidos$disallow_zero_length] CHECK (len([Apellidos])>(0)),
    CONSTRAINT [SSMA_CC$SalxCli$Nombres$disallow_zero_length] CHECK (len([Nombres])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli].[TotalCreditos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli', @level2type = N'COLUMN', @level2name = N'TotalCreditos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli].[TotalAbonos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli', @level2type = N'COLUMN', @level2name = N'TotalAbonos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli].[Saldo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli', @level2type = N'COLUMN', @level2name = N'Saldo';

