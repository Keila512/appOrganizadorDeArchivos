using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Vlc.DotNet.Forms;
using LibVLCSharp;
using System.Windows.Forms;

namespace appOrganizadorDeArchivos
{
    public partial class Form1 : Form
    {
        DirectoryInfo folderInfo;
        ArrayList listaArchivos;
        public Form1()
        {
            InitializeComponent();
            folderInfo = null;
            listaArchivos = new ArrayList();
        }
        
        private void btnopen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog () != DialogResult.OK)
            {
                return;
            }
            folderInfo = new DirectoryInfo(fbd.SelectedPath);
            LlenarListaArchivos(folderInfo);
            LlenarArbol(folderInfo, tuvFiles.Nodes);
        }
        private void LlenarArbol(DirectoryInfo folder, TreeNodeCollection nodo)
        {
            TreeNode n = nodo.Add(folder.Name);
            foreach (FileInfo fi in folder.GetFiles())
            {
                n.Nodes.Add(fi.FullName, fi.Name);
            }
            foreach(DirectoryInfo di in folder.GetDirectories()) 
            {
                LlenarArbol(di, n.Nodes);
                LlenarArbol(folderInfo, tuvFiles.Nodes);
            }
        }
        private void tuvFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                picimagenes.Image = Image.FromFile(e.Node.Name);
                picimagenes.Size = new Size(827, 439);
                rtbtext.Size = new Size(0, 0);
                vlcControl1.Size = new Size(0, 0);
                return;
            }
            catch { }
            try
            {
                vlcControl1.Play(new Uri(e.Node.Name));
                picimagenes.Size = new Size(0,0);
                vlcControl1.Size = new Size(827, 439);
                rtbtext.Size = new Size(0, 0);
                return;
            }
            catch { }
            try
            {
                StreamReader sr = new StreamReader(e.Node.Name);
                rtbtext.Text = sr.ReadToEnd();
                rtbtext.Size = new Size(827, 439);
                picimagenes.Size = new Size(0, 0);
                vlcControl1.Size = new Size(0, 0);
                return;
            }
            catch { }
        }

        private void LlenarListaArchivos(DirectoryInfo directory) 
        {
            foreach(FileInfo fi in directory.GetFiles()) 
            {
                listaArchivos.Add(fi.FullName);
            }
            foreach (DirectoryInfo di2 in directory.GetDirectories())
            {
                LlenarListaArchivos(di2);
            }
        }


        private void btnorganize_Click(object sender, EventArgs e)
        {
            DirectoryInfo carpetaImagenes = Directory.CreateDirectory(folderInfo.FullName + "\\Carpeta Organizada\\Carpeta Organizada de Imagenes\\");
            DirectoryInfo carpetaDocumentos = Directory.CreateDirectory(folderInfo.FullName + "\\Carpeta Organizada\\Carpeta Organizada de Documentos\\");
            DirectoryInfo carpetaAudios = Directory.CreateDirectory(folderInfo.FullName + "\\Carpeta Organizada\\Carpeta Organizada de Audio\\");
            DirectoryInfo carpetaVideos = Directory.CreateDirectory(folderInfo.FullName + "\\Carpeta Organizada\\Carpeta Organizada de Videos\\");
            DirectoryInfo carpetaOtros =  Directory.CreateDirectory(folderInfo.FullName + "\\Carpeta Organizada\\Carpeta Organizada de Otros\\");

            foreach (FileInfo fi in listaArchivos) 
            {
                if (fi.Extension.ToLower() == ".png" || fi.Extension.ToLower() == ".jpg" || fi.Extension.ToLower() == ".jpeg")
                {
                    if (!File.Exists(carpetaImagenes.FullName + fi.Name))
                    {
                        File.Copy(fi.FullName, carpetaImagenes.FullName + fi.Name);
                    }
                }
                if (fi.Extension.ToLower() == ".mp3" || fi.Extension.ToLower() == ".m4a" || fi.Extension.ToLower() == ".wav")
                {
                    if (!File.Exists(carpetaAudios.FullName + fi.Name))
                    {
                        File.Copy(fi.FullName, carpetaAudios.FullName + fi.Name);
                    }
                }
                if (fi.Extension.ToLower() == ".mp4" || fi.Extension.ToLower() == ".mov" || fi.Extension.ToLower() == ".avi")
                {
                    if (!File.Exists(carpetaVideos.FullName + fi.Name))
                    {
                        File.Copy(fi.FullName, carpetaVideos.FullName + fi.Name);
                    }
                }
                if (fi.Extension.ToLower() == ".docx" || fi.Extension.ToLower() == ".xlsx" || fi.Extension.ToLower() == ".pdf")
                {
                    if (!File.Exists(carpetaDocumentos.FullName + fi.Name))
                    {
                        File.Copy(fi.FullName, carpetaDocumentos.FullName + fi.Name);
                    }
                }
                else
                {
                    if (!File.Exists(carpetaImagenes.FullName + fi.Name))
                    {
                        File.Copy(fi.FullName, carpetaImagenes.FullName + fi.Name);
                    }
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }
    }
}
