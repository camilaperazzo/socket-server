namespace SocketServer
{
	public partial class socketserver : Form 
	{
		
		clsSocketServer mServer = new clsSocketServer();
		clLog clLog = new clLog();
		public socketserver()
		{
			InitializeComponent();

			mServer.ParentForm = this;

			mServer.MessageReceived += MServer_MessageReceived;
			mServer.ConnectionReceived += MServer_ConnectionReceived;
			mServer.Disconnection += MServer_Disconnection;
		}

		private void MServer_Disconnection(string IP)
		{
			lbInfo.Items.Add($"Desconectado");
			clLog.WriteLog(IP + " Desconectado ");
		}

		private void MServer_ConnectionReceived(string IP)
		{
			lbInfo.Items.Add($"Conexão Recebida por: " + mServer.clientip);
			lbClientBox.DataSource = mServer.tcpClients.Select(s => s.Client.RemoteEndPoint.ToString()).ToList();
			clLog.WriteLog("Conexão Recebida por: " + mServer.clientip);
			
		}

		private void MServer_MessageReceived(string Message)
		{
			lbInfo.Items.Add($"Client: "+ Message);
			clLog.WriteLog($"Client: " + Message);
		}

		private void btnListen_Click(object sender, EventArgs e)
		{
			lbInfo.Items.Add("Server Started on Port: " + txtPort.Text);
			
			mServer.StartListen(txtIP.Text, Int32.Parse(txtPort.Text));

			clLog.WriteLog("Server Started on Port: " + txtPort.Text);

		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (lbClientBox.SelectedIndex == -1)
				return;

			mServer.SendMessage(txtMessage.Text, lbClientBox.SelectedValue.ToString());
			lbInfo.Items.Add($"Server: " + txtMessage.Text);

			clLog.WriteLog($"Server: " + txtMessage.Text);
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			lbInfo.Items.Add(" StopListenning Acionado");
			mServer.StopListen();
		}

        private void btnCloseConnection_Click(object sender, EventArgs e)
        {
			mServer.CloseConnection(lbClientBox.SelectedValue.ToString());
			lbClientBox.DataSource = mServer.tcpClients.Select(s => s.Client.RemoteEndPoint.ToString()).ToList();
		}

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
			mServer.CloseAllConnections();
			lbClientBox.DataSource = mServer.tcpClients.Select(s => s.Client.RemoteEndPoint.ToString()).ToList();
		}
    }
}