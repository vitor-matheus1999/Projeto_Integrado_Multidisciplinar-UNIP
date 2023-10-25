package Model.Negocio;

import java.util.Date;
import java.util.Calendar;

public class Empresa {

    private Integer idEmpresa;
    private String nomeEmpresarialFantasia;
    private String cnae;
    private String cnpj;
    private String situacaoCadastral;
    private String naturezaJuridica;
    private Date dataAbertura;
    private String atividadesEconomicas;


    public Empresa(){}

    public Empresa(Integer idEmpresa, String nomeEmpresarialFantasia, String cnae, String cnpj, String situacaoCadastral, String naturezaJuridica, Date dataAbertura, String atividadesEconomicas) {
        this.idEmpresa = idEmpresa;
        this.nomeEmpresarialFantasia = nomeEmpresarialFantasia;
        this.cnae = cnae;
        this.cnpj = cnpj;
        this.situacaoCadastral = situacaoCadastral;
        this.naturezaJuridica = naturezaJuridica;
        this.dataAbertura = dataAbertura;
        this.atividadesEconomicas = atividadesEconomicas;
    }


    public void setIdEmpresa(Integer idEmpresa) {
        this.idEmpresa = idEmpresa;
    }

    public String getNomeEmpresarialFantasia() {
        return nomeEmpresarialFantasia;
    }

    public void setNomeEmpresarialFantasia(String nomeEmpresarialFantasia) {
        this.nomeEmpresarialFantasia = nomeEmpresarialFantasia;
    }

    public String getCnae() {
        return cnae;
    }

    public void setCnae(String cnae) {
        this.cnae = cnae;
    }

    public String getCnpj() {
        return cnpj;
    }

    public void setCnpj(String cnpj) {
        this.cnpj = cnpj;
    }

    public String getSituacaoCadastral() {
        return situacaoCadastral;
    }

    public void setSituacaoCadastral(String situacaoCadastral) {
        this.situacaoCadastral = situacaoCadastral;
    }

    public String getNaturezaJuridica() {
        return naturezaJuridica;
    }

    public void setNaturezaJuridica(String naturezaJuridica) {
        this.naturezaJuridica = naturezaJuridica;
    }

    public Date getDataAbertura() {
        return dataAbertura;
    }

    public void setDataAbertura(Date dataAbertura) {
        this.dataAbertura = dataAbertura;
    }

    public String getAtividadesEconomicas() {
        return atividadesEconomicas;
    }

    public void setAtividadesEconomicas(String atividadesEconomicas) {
        this.atividadesEconomicas = atividadesEconomicas;
    }

}
