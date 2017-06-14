CREATE TABLE [dbo].[PrimEstCta] (
    [CodigoCliente]  INT        NULL,
    [Numero]         INT        NULL,
    [DebeAnt]        FLOAT (53) NULL,
    [HaberAnt]       FLOAT (53) NULL,
    [SalAnt]         FLOAT (53) NULL,
    [SSMA_TimeStamp] ROWVERSION NOT NULL
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[PrimEstCta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PrimEstCta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[PrimEstCta].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PrimEstCta', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[PrimEstCta].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PrimEstCta', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[PrimEstCta].[DebeAnt]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PrimEstCta', @level2type = N'COLUMN', @level2name = N'DebeAnt';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[PrimEstCta].[HaberAnt]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PrimEstCta', @level2type = N'COLUMN', @level2name = N'HaberAnt';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[PrimEstCta].[SalAnt]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PrimEstCta', @level2type = N'COLUMN', @level2name = N'SalAnt';

