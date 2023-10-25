package Model.Negocio;

import java.util.Date;
import java.util.Calendar;

public class Funcionario {

    private Integer idFuncionario;
    private Integer idEmpresa;
    private Integer idSetor;
    private Integer idContatoFuncionario;
    private Integer idEnderecoFuncionario;
    private Integer idLoginSenha;
    private String senha;
    private String nomeFuncionario;
    private String generoFuncionario;
    private Date dataNascimento;
    private Date dataAdmissao;
    private String cpfFuncionario;
    private Double horasNaoTrabalhadas;
    private Double horasExtras;
    private String tipoContato;
    private String descricaoContato;
    private String senhaSistemaDesktop;
    private String rua;
    private String numeroMoradia;
    private String bairro;
    private String cepResidencia;
    private String cidadeMoradia;
    private Double salarioSeraAcrescentadoDevidoHorasExtras;
    private Boolean holeriteFinalizado;
    private Boolean funcionarioArquivado;

    public Funcionario() {
    }

    public Funcionario(Integer idFuncionario, Integer idEmpresa, Integer idSetor, String nomeFuncionario, Date dataNascimento,Date dataAdmissao,String generoFuncionario,String cpfFuncionario, Double horasNaoTrabalhadas, Double horasExtras, Double salarioSeraAcrescentadoDevidoHorasExtras,Boolean holeriteFinalizado, Boolean funcionarioArquivado){

        this.idFuncionario = idFuncionario;
        this.idEmpresa = idEmpresa;
        this.idSetor = idSetor;
        this.nomeFuncionario = nomeFuncionario;
        this.dataNascimento = dataNascimento;
        this.dataAdmissao = dataAdmissao;
        this.generoFuncionario = generoFuncionario;
        this.cpfFuncionario = cpfFuncionario;
        this.horasNaoTrabalhadas = horasNaoTrabalhadas;
        this.horasExtras = horasExtras;
        this.salarioSeraAcrescentadoDevidoHorasExtras = salarioSeraAcrescentadoDevidoHorasExtras;
        this.holeriteFinalizado = holeriteFinalizado;
        this.funcionarioArquivado = funcionarioArquivado;
    }

    public Funcionario(String emailEmpresarial, String senhaSistemaDesktop){
        this.descricaoContato = emailEmpresarial;
        this.senhaSistemaDesktop = senhaSistemaDesktop;
    }


    public Integer getIdFuncionario() {
        return idFuncionario;
    }

    public void setIdFuncionario(Integer idFuncionario) {
        this.idFuncionario = idFuncionario;
    }

    public Integer getIdEmpresa() {
        return idEmpresa;
    }

    public void setIdEmpresa(Integer idEmpresa) {
        this.idEmpresa = idEmpresa;
    }

    public Integer getIdSetor() {
        return idSetor;
    }

    public void setIdSetor(Integer idSetor) {
        this.idSetor = idSetor;
    }

    public Integer getIdContatoFuncionario() {
        return idContatoFuncionario;
    }

    public void setIdContatoFuncionario(Integer idContatoFuncionario) {
        this.idContatoFuncionario = idContatoFuncionario;
    }

    public Integer getIdEnderecoFuncionario() {
        return idEnderecoFuncionario;
    }

    public void setIdEnderecoFuncionario(Integer idEnderecoFuncionario) {
        this.idEnderecoFuncionario = idEnderecoFuncionario;
    }

    public Integer getIdLoginSenha() {
        return idLoginSenha;
    }

    public void setIdLoginSenha(Integer idLoginSenha) {
        this.idLoginSenha = idLoginSenha;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }

    public String getNomeFuncionario() {
        return nomeFuncionario;
    }

    public void setNomeFuncionario(String nomeFuncionario) {
        this.nomeFuncionario = nomeFuncionario;
    }

    public String getGeneroFuncionario() {
        return generoFuncionario;
    }

    public void setGeneroFuncionario(String generoFuncionario) {
        this.generoFuncionario = generoFuncionario;
    }

    public Date getDataNascimento() {
        return dataNascimento;
    }

    public void setDataNascimento(Date dataNascimento) {
        this.dataNascimento = dataNascimento;
    }

    public Date getDataAdmissao() {
        return dataAdmissao;
    }

    public void setDataAdmissao(Date dataAdmissao) {
        this.dataAdmissao = dataAdmissao;
    }

    public String getCpfFuncionario() {
        return cpfFuncionario;
    }

    public void setCpfFuncionario(String cpfFuncionario) {
        this.cpfFuncionario = cpfFuncionario;
    }

    public Double getHorasNaoTrabalhadas() {
        return horasNaoTrabalhadas;
    }

    public void setHorasNaoTrabalhadas(Double horasNaoTrabalhadas) {
        this.horasNaoTrabalhadas = horasNaoTrabalhadas;
    }

    public Double getHorasExtras() {
        return horasExtras;
    }

    public void setHorasExtras(Double horasExtras) {
        this.horasExtras = horasExtras;
    }

    public String getTipoContato() {
        return tipoContato;
    }

    public void setTipoContato(String tipoContato) {
        this.tipoContato = tipoContato;
    }

    public String getDescricaoContato() {
        return descricaoContato;
    }

    public void setDescricaoContato(String descricaoContato) {
        this.descricaoContato = descricaoContato;
    }

    public String getSenhaSistemaDesktop() {
        return senhaSistemaDesktop;
    }

    public void setSenhaSistemaDesktop(String senhaSistemaDesktop) {
        this.senhaSistemaDesktop = senhaSistemaDesktop;
    }

    public String getRua() {
        return rua;
    }

    public void setRua(String rua) {
        this.rua = rua;
    }

    public String getNumeroMoradia() {
        return numeroMoradia;
    }

    public void setNumeroMoradia(String numeroMoradia) {
        this.numeroMoradia = numeroMoradia;
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        this.bairro = bairro;
    }

    public String getCepResidencia() {
        return cepResidencia;
    }

    public void setCepResidencia(String cepResidencia) {
        this.cepResidencia = cepResidencia;
    }

    public String getCidadeMoradia() {
        return cidadeMoradia;
    }

    public void setCidadeMoradia(String cidadeMoradia) {
        this.cidadeMoradia = cidadeMoradia;
    }

    public Double getSalarioSeraAcrescentadoDevidoHorasExtras() {
        return salarioSeraAcrescentadoDevidoHorasExtras;
    }

    public void setSalarioSeraAcrescentadoDevidoHorasExtras(Double salarioSeraAcrescentadoDevidoHorasExtras) {
        this.salarioSeraAcrescentadoDevidoHorasExtras = salarioSeraAcrescentadoDevidoHorasExtras;
    }

    public Boolean getHoleriteFinalizado() {
        return holeriteFinalizado;
    }

    public void setHoleriteFinalizado(Boolean holeriteFinalizado) {
        this.holeriteFinalizado = holeriteFinalizado;
    }

    public Boolean getFuncionarioArquivado() {
        return funcionarioArquivado;
    }

    public void setFuncionarioArquivado(Boolean funcionarioArquivado) {
        this.funcionarioArquivado = funcionarioArquivado;
    }
}
