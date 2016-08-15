<%@ page title="" language="C#" masterpagefile="~/MasterPageWeb.Master" autoeventwireup="true" codebehind="MenuInicial.aspx.cs" inherits="DengueZero.MenuInicial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?v=3&sensor=true" async defer></script>
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="server">
    <!-- Banner -->
    <section id="banner">
        <div id="mapa">
        </div>
    </section>

    <!-- Highlights -->
    <section class="wrapper style1">
        <div class="container">
            <div class="col-md-12" style="padding:15px;">
                <asp:Label ID="lblErro" runat="server" ClientIDMode="Static"></asp:Label>
                <div class="col-md-6">
                    <div class="col-md-6">
                        <asp:Label ID="lblPais" runat="server" Text="País"></asp:Label>
                        <asp:TextBox ID="txtPais" ClientIDMode="Static" runat="server" Width="250px"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                        <asp:TextBox ID="txtEstado" ClientIDMode="Static" runat="server" Width="250px"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6" style="padding-top: 15px;">
                        <div class="col-md-6">
                            <asp:Label ID="lblStatusFoco" runat="server" Text="Situação do Foco"></asp:Label>
                            <asp:DropDownList ID="ddlStatus" ClientIDMode="Static" runat="server" style="border-radius:7px; height: 33px; width: 110px;"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                             <asp:Button ID="btnPesquisar" ClientIDMode="Static" runat="server" Text="Pesquisar" OnClientClick="carregaEndereco(event);" />
                        </div>

                    </div>
<<<<<<< HEAD
                    <div class="6u 12u(mobilep)">
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro"></asp:Label>
                        <asp:TextBox ID="txtBairro" runat="server" ClientIDMode="Static" Width="250px"></asp:TextBox>
                    </div>
                    <div class="6u 12u(mobilep)">
                        <asp:Label ID="lblEndereco" runat="server" Text="Rua"></asp:Label>
                        <asp:TextBox ClientIDMode="Static" ID="txtEndereco" runat="server" Width="250px"></asp:TextBox>
                    </div>
                    <div class="6u 12u(mobilep)">
                        <asp:Label ID="lblStatusFoco" runat="server" Text="Situação do Foco"></asp:Label><br />
                        <asp:DropDownList ID="ddlStatus" ClientIDMode="Static" runat="server" Height="30px" Style="border-radius: 4px; border-color: lightgrey;"></asp:DropDownList>
                    </div>
                </div>

                <div class="row 50%">
                    <div class="6u 12u(mobilep)">
                        <asp:Label ID="lblDescricao" runat="server" Text="Descrição do Foco"></asp:Label>
                        <asp:TextBox ClientIDMode="Static" ID="txtDescricao" runat="server" Width="250px" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>

                <div class="row 50%">
                    <asp:UpdatePanel ID="uppAtualizar" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="btnPesquisar" ClientIDMode="Static" runat="server" Text="Pesquisar" OnClientClick="carregaEndereco(event);" Style="text-align: center;" />
                            <asp:Button ID="btnAtualizarMapa" ClientIDMode="Static" runat="server" Text="Buscar Focos Registrados" OnClick="btnAtualizarMapa_Click" />
                            <asp:Button ID="btnSalvar" ClientIDMode="Static" runat="server" Text="Salvar Registro" OnClick="btnSalvar_Click" Enabled="false" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
=======
                    </div>
                <div class="col-md-12">
                    <div class="col-md-6">
                        <div class="col-md-6">
                            <asp:Label ID="lblCidade" runat="server" Text="Cidade"></asp:Label>
                            <asp:TextBox ID="txtCidade" ClientIDMode="Static" runat="server" Width="250px"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblEndereco" runat="server" Text="Rua"></asp:Label>
                            <asp:TextBox ClientIDMode="Static" ID="txtEndereco" runat="server" Width="200px"></asp:TextBox>
                        </div>
                  </div>
                    <div class="col-md-6" style="padding:20px;">
                        <asp:UpdatePanel ID="uppAtualizar" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="btnAtualizarMapa" ClientIDMode="Static" runat="server" Text="Buscar Focos Registrados" OnClick="btnAtualizarMapa_Click" />
                                <asp:Button ID="btnSalvar" ClientIDMode="Static" runat="server" Text="Salvar Registro" OnClick="btnSalvar_Click" Enabled="false" />
                            </ContentTemplate>
                    </asp:UpdatePanel>
                    </div>
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
                </div>
            </section>
            <br />

<<<<<<< HEAD
             <div class="col-md-12" style="text-align: center; padding: 28px;">
                <h3 id="prevencao">O que fazer</h3>
                <a href="#" style="text-align: right; color: #000000"><span class="glyphicon glyphicon-arrow-up" aria-hidden="true"></span> </a>
=======
            <div class="col-md-12" style="text-align: center; padding: 28px;">
                <h3 id="prevencao">O que fazer</h3>
                <a href="MenuInicial.aspx" style="text-align: right; color: #000000"><span class="glyphicon glyphicon-arrow-up" aria-hidden="true"></span> </a>
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
            </div>
        

        <div class=" container">
            <div class="col-md-4">
      
                <div class="box highlight ">
                    <img src="img/prevencao.png" />
                    <h3>Prevenções</h3>
                    <p>Mantenha o seu ambiente seco e limpo. É importante verificar 2 vezes por semana materiais onde podem aglomerar água parada.</p>
                </div>
   
           </div>
            <div class="col-md-4">
                <div class="box highlight ">
                    <img src="img/sintomas.png" />
                    <h3>Sintomas</h3>
                    <p>Febre alta, forte dor de cabeça, dor atrás dos olhos, perda de paladar e apetite, manchas na pele, corpo mole, vômitos e etc.</p>
                </div>
                </div>
            <div class="col-md-4">
                <div class="box highlight ">
                    <img src="img/tendoSintomas.png" />
                    <h3>Tendo Sintomas</h3>
                    <p>Ao sentir os sintomas não pode tomar qualquer tipo de remédio, o melhor a fazer é procurar o posto de saúde mais perto para avaliação.</p>
                </div>
                </div>
<<<<<<< HEAD
=======
        </div>
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
        </div>
    </section>

    <!-- Posts -->
    <section class="wrapper style1">
        <div class="container">

<<<<<<< HEAD
            <div class="col-md-12" style="text-align:center">
                <h3 id="agindo">Agindo Contra Dengue</h3>
                <a href="#" style="text-align: right; color: #000000"><span class="glyphicon glyphicon-arrow-up" aria-hidden="true"></span> </a>
=======
            <div class="col-md-12" style="text-align: center;">
                <h3 id="agindo">Agindo Contra Dengue</h3>
                <a href="MenuInicial.aspx" style="text-align: right; color: #000000"><span class="glyphicon glyphicon-arrow-up" aria-hidden="true"></span> </a>
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
            </div>

            <div class="row">
                <section class="6u 12u(narrower)">
                    <div class="box post">
                        <a href="#" class="image left">
                            <img src="img/lixeira.png" alt="" /></a>
                        <div class="inner">
                            <h3>Lixo na Lixeira</h3>
                            <p>É importante a conscientização de todos para que possamos vencer o mosquito da dengue, isso pode ocorrer com a ajuda de todos.</p>
                        </div>
                    </div>
                </section>
                <section class="6u 12u(narrower)">
                    <div class="box post">
                        <a href="#" class="image left">
                            <img src="img/exemploCasa.png" alt="" /></a>
                        <div class="inner">
                            <h3>De exemplos em casa</h3>
                            <p>Em sua casa realize operações contra a proliferação do mosquito, mantenha o local limpo e sem água parada sempre.</p>
                        </div>
                    </div>
                </section>
            </div>
            <div class="row">
                <section class="6u 12u(narrower)">
                    <div class="box post">
                        <a href="#" class="image left">
                            <img src="img/denuncie.png" alt="" /></a>
                        <div class="inner">
                            <h3>Denuncie</h3>
                            <p>Denuncie os focos encontrados para as autoridades responsáveis.</p>
                        </div>
                    </div>
                </section>
                <section class="6u 12u(narrower)">
                    <div class="box post">
                        <a href="#" class="image left">
                            <img src="img/denuncieSite.png" alt="" /></a>
                        <div class="inner">
                            <h3>Compartilhe Focos encontrados no site</h3>
                            <p>Em nosso site denuncie os focos com o posicionamento real.</p>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    </section>

    <!-- Footer -->
    <div id="footer">
        <div class="container">
            <div class="row">

                <section class="6u 12u(narrower)">
                    <h3>Entre em contato</h3>
                    <div class="row 50%">
                        <div class="6u 12u(mobilep)">
                            <input type="text" name="name" id="name" placeholder="Nome" />
                        </div>
                        <div class="6u 12u(mobilep)">
                            <input type="email" name="email" id="email" placeholder="Email" />
                        </div>
                    </div>
                    <div class="row 50%">
                        <div class="12u">
                            <textarea name="message" id="message" placeholder="Mensagem" rows="5"></textarea>
                        </div>
                    </div>
                    <div class="row 50%">
                        <div class="12u">
                            <ul class="actions">
                                <li>
                                    <input type="submit" class="button alt" value="Enviar Mensagem" /></li>
                            </ul>
                        </div>
                    </div>
                </section>
            </div>
        </div>

        <!-- Icones -->
        <ul class="icons">
            <li><a href="#" class="icon fa-twitter"><span class="label">Twitter</span></a></li>
            <li><a href="#" class="icon fa-facebook"><span class="label">Facebook</span></a></li>
            <li><a href="#" class="icon fa-github"><span class="label">GitHub</span></a></li>
            <li><a href="#" class="icon fa-linkedin"><span class="label">LinkedIn</span></a></li>
            <li><a href="#" class="icon fa-google-plus"><span class="label">Google+</span></a></li>
        </ul>

        <!-- Copyright -->
        <div class="copyright">
            <ul class="menu">
                <li>&copy; Dengue Zero: Leonardo, Pedro Paulo, Sérgio, Walisson</li>
            </ul>
        </div>

    </div>
</asp:content>
