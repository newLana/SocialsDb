using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialsADO
{
    public partial class Form1 : Form
    {
        DataSet db;
        int currentPhotoId;
        int currentCommentId;

        public Form1()
        {
            InitializeComponent();
            db = new DbCreator().SocialsDb;
            dgvPhoto.DataSource = ViewPhotoTable();
            dgvUsers.DataSource = ViewUsers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPhoto.Rows[dgvPhoto.Rows.Count - 1].Cells["Author"] = SetingComboCell();
        }

        #region Interface
        private void dgvLikes_DataSourceChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).DataSource != null)
            {
                (sender as DataGridView).Columns[0].Visible = false;
                (sender as DataGridView).Rows[(sender as DataGridView).NewRowIndex].Cells[1] = SetingComboCell();
            }
        }
        
        private DataGridViewComboBoxCell SetingComboCell()
        {
            return new DataGridViewComboBoxCell()
            {
                DataSource = db.Tables["Users"],
                DisplayMember = "Name"                
            };
        }


        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                int deletePhotoId;      
                if (dgvPhoto.SelectedRows.Count == 1 && dgvPhoto.SelectedRows[0].Index < dgvPhoto.Rows.Count - 1 && Int32.TryParse(dgvPhoto.CurrentRow.Cells[2].Value.ToString(), out deletePhotoId))
                {                                  
                    var row = db.Tables["Photos"].AsEnumerable().FirstOrDefault(r => (int)r["Id"] == deletePhotoId);
                    db.Tables["Photos"].Rows.Remove(row);
                    UpdateDataSources();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPhoto_DataSourceChanged(object sender, EventArgs e)
        {
            ((DataGridView)sender).Columns[0].Visible = false;
            ((DataGridView)sender).Columns[2].Visible = false;
            ((DataGridView)sender).Columns[4].ReadOnly = true;
            ((DataGridView)sender).Columns[5].ReadOnly = true;
            dgvPhoto.Rows[dgvPhoto.Rows.Count - 1].Cells[1] = SetingComboCell();
        }

        private void dgvPhoto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(!((DataGridView)sender).CurrentRow.IsNewRow)
                {
                    if (!Int32.TryParse(((DataGridView)sender).CurrentRow.Cells[2].Value.ToString(), out currentPhotoId))
                        currentPhotoId = 0;
                }
                else
                {
                    currentPhotoId = 0;
                }
                dgvPhotoLikes.DataSource = ViewPeopleWhoLikesPhoto(currentPhotoId);
                dgvComments.DataSource = ViewCommentsToPhoto(currentPhotoId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPhoto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell is DataGridViewComboBoxCell)
            {
                (e.Control as ComboBox).SelectedIndexChanged += dvgPhoto_SelectedIndexChanged;
            }
        }

        private void dvgPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((ComboBox)sender).SelectedItem is DataRowView)
                {
                    int value;
                    string enterStr = (((ComboBox)sender).SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                    if (Int32.TryParse(enterStr, out value))
                        dgvPhoto.CurrentRow.Cells[0].Value = value;
                }
            }
            catch (Exception idExc)
            {
                MessageBox.Show(idExc.Message);
            }
            (sender as ComboBox).SelectedIndexChanged -= dvgComment_SelectedIndexChanged;
        }


        private void dgvPhoto_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dgvPhoto.SelectionChanged += DgvPhoto_SelectionChangedAfterAdeedRow;
        }

        private void dgvPhoto_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex != db.Tables["Photos"].Rows.Count && (e.ColumnIndex == 1 || e.ColumnIndex == 3))
            {
                ((DataGridView)sender).CancelEdit();
            }
        }

        private void DgvPhoto_SelectionChangedAfterAdeedRow(object sender, EventArgs e)
        {
            try
            {
                var newRow = dgvPhoto.Rows[dgvPhoto.RowCount - 2];
                int userId;
                string photoName = newRow.Cells["Photo"].Value.ToString();
                if (Int32.TryParse(newRow.Cells["AuthorId"].Value.ToString(), out userId) 
                    && db.Tables["Users"].AsEnumerable().Any(u => (int)u.ItemArray[0] == userId)
                     && !String.IsNullOrEmpty(photoName))
                {
                    db.Tables["Photos"].LoadDataRow(new object[]
                    {
                        null,
                        photoName,
                        userId
                    }, false);
                    dgvPhoto.AllowUserToAddRows = true;
                    this.dgvPhoto.SelectionChanged -= DgvPhoto_SelectionChangedAfterAdeedRow;
                    UpdateDataSources();
                }
                else
                {
                    dgvPhoto.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex
.Message);
            }
        }


        private void dgvComments_DataSourceChanged(object sender, EventArgs e)
        {
            ((DataGridView)sender).Columns[0].Visible = false;
            ((DataGridView)sender).Columns[2].Visible = false;
            ((DataGridView)sender).Columns[4].ReadOnly = true;
            (sender as DataGridView).Rows[(sender as DataGridView).NewRowIndex].Cells[3] = SetingComboCell();
        }

        private void dgvComments_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (((DataGridView)sender).SelectedRows.Count > 0 && ((DataGridView)sender).SelectedRows[0].Index < ((DataGridView)sender).RowCount-1)
                {
                    if(Int32.TryParse(((DataGridView)sender).CurrentRow.Cells[0].Value.ToString(), out currentCommentId))
                        dgvLikesComment.DataSource = ViewPeopleWhoLikesComment(currentCommentId);
                }
                else
                {
                    dgvLikesComment.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvComments_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell is DataGridViewComboBoxCell)
            {                
                (e.Control as ComboBox).SelectedIndexChanged += dvgComment_SelectedIndexChanged;
            }
        }

        private void dvgComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((ComboBox)sender).SelectedItem is DataRowView)
                {
                    int value;
                    string enterStr = (((ComboBox)sender).SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                    if (Int32.TryParse(enterStr, out value))
                        dgvComments.CurrentRow.Cells[2].Value = value;
                }
            }
            catch (Exception idExc)
            {
                MessageBox.Show(idExc.Message);
            }
            (sender as ComboBox).SelectedIndexChanged -= dvgComment_SelectedIndexChanged;
        }       
       
        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteCommentId;
                if (dgvComments.SelectedRows.Count == 1 && dgvComments.SelectedRows[0].Index < dgvComments.Rows.Count - 1 && Int32.TryParse(dgvComments.SelectedRows[0].Cells[0].Value.ToString(), out deleteCommentId))
                {
                    var row = db.Tables["Comments"].AsEnumerable().FirstOrDefault(r => (int)r["Id"] == deleteCommentId);
                    db.Tables["Comments"].Rows.Remove(row);

                    UpdateDataSources();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvComments_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex != db.Tables["Comments"].AsEnumerable().Count(r => (Int32)r["PhotoId"] == currentPhotoId) && !(((DataGridView)sender).CurrentCell is DataGridViewComboBoxCell))
            {
                ((DataGridView)sender).CancelEdit();
            }
        }


        private void dgvComments_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.dgvComments.SelectionChanged += dgvComments_SelectionAfterAddedNewRowChanged;
        }

        private void dgvComments_SelectionAfterAddedNewRowChanged(object sender, EventArgs e)
        {
            try
            {                
                    var newRow = dgvComments.Rows[dgvComments.RowCount - 2];
                    var comment = newRow.Cells["Comment"].Value.ToString();
                    int userId;
                    if (Int32.TryParse(newRow.Cells[2].Value.ToString(), out userId)
                        && db.Tables["Users"].AsEnumerable().Any(u => (int)u.ItemArray[0] == userId)
                        && db.Tables["Photos"].AsEnumerable().Any(p => (int)p.ItemArray[0] == currentPhotoId)
                        && !String.IsNullOrEmpty(comment))
                    {
                        var row = db.Tables["Comments"].LoadDataRow(new object[]
                        {
                    null,
                    comment,
                    userId,
                    currentPhotoId
                        }, false);
                        if (row != null)
                        {
                            dgvComments.AllowUserToAddRows = true;
                            this.dgvComments.SelectionChanged -= dgvComments_SelectionAfterAddedNewRowChanged;
                            UpdateDataSources();
                        }
                    }
                    else
                    {
                        dgvComments.AllowUserToAddRows = false;
                    }
                }
            
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }

      

        private void UpdateDataSources()
        {
            dgvPhoto.DataSource = ViewPhotoTable();

            dgvComments.DataSource = ViewCommentsToPhoto(currentPhotoId);
            dgvLikesComment.DataSource = ViewPeopleWhoLikesComment(currentCommentId);
            dgvPhotoLikes.DataSource = ViewPeopleWhoLikesPhoto(currentPhotoId);
            dgvUsers.DataSource = ViewUsers();
        }

               

        private void dgvPhotoLikes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell is DataGridViewComboBoxCell)
            {
                (e.Control as ComboBox).SelectedIndexChanged -= dgvPhotoLikes_SelectedIndexChanged;
                (e.Control as ComboBox).SelectedIndexChanged += dgvPhotoLikes_SelectedIndexChanged;
            }
        }

        private void dgvPhotoLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(((ComboBox)sender).SelectedItem is DataRowView)
                {  
                    int value;
                    string enterStr = (((ComboBox)sender).SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                    if (Int32.TryParse(enterStr, out value))
                        this.dgvPhotoLikes.CurrentRow.Cells[0].Value = value;
                }
            }
            catch (Exception idExc)
            {
                MessageBox.Show(idExc.Message);
            }
        }

        private void dgvCommentLikes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell is DataGridViewComboBoxCell)
            {
                (e.Control as ComboBox).SelectedIndexChanged -= dgvCommentLikes_SelectedIndexChanged;
                (e.Control as ComboBox).SelectedIndexChanged += dgvCommentLikes_SelectedIndexChanged;
            }
        }

        private void dgvCommentLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((ComboBox)sender).SelectedItem is DataRowView)
                {
                    int value;
                    string enterStr = (((ComboBox)sender).SelectedItem as DataRowView).Row.ItemArray[0].ToString();
                    if (Int32.TryParse(enterStr, out value))
                        this.dgvLikesComment.CurrentRow.Cells[0].Value = value;
                }
            }
            catch (Exception idExc)
            {
                MessageBox.Show(idExc.Message);
            }
        }        

        private void btnDeletePhotoLike_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteLikeId;
                if (dgvPhotoLikes.SelectedRows.Count == 1 && dgvPhotoLikes.SelectedRows[0].Index < dgvPhotoLikes.Rows.Count - 1 && Int32.TryParse(dgvPhotoLikes.SelectedRows[0].Cells[0].Value.ToString(), out deleteLikeId))
                {
                    var row = db.Tables["UsersPhotos"].AsEnumerable().FirstOrDefault(r => (int)r["UserId"] == deleteLikeId && (int)r["PhotoId"] == currentPhotoId);
                    db.Tables["UsersPhotos"].Rows.Remove(row);
                    UpdateDataSources();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCommentLike_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLikesComment.DataSource != null)
                { int deleteLikeId;
                    if (dgvLikesComment.SelectedRows[0].Index < dgvLikesComment.Rows.Count - 1 && Int32.TryParse(dgvLikesComment.SelectedRows[0].Cells[0].Value.ToString(), out deleteLikeId))
                    {
                        var row = db.Tables["UsersComments"].AsEnumerable().FirstOrDefault(r => (int)r["UserId"] == deleteLikeId && (int)r["CommentId"] == currentCommentId);
                        db.Tables["UsersComments"].Rows.Remove(row);
                        UpdateDataSources();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLikes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!(((DataGridView)sender).CurrentCell is DataGridViewComboBoxCell))
            {
                ((DataGridView)sender).CancelEdit();
            }
        }

        private void dgvLikesComment_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.dgvLikesComment.SelectionChanged += dgvLikesComment_SelectionChangedAfterAddedNewRow;
        }

        private void dgvLikesComment_SelectionChangedAfterAddedNewRow(object sender, EventArgs e)
        {
            try
            {
                var newRow = dgvLikesComment.Rows[dgvLikesComment.RowCount - 2];
                int userId;
                if (Int32.TryParse(newRow.Cells["Id"].Value.ToString(), out userId) && db.Tables["Users"].AsEnumerable().Any(u => (int)u.ItemArray[0] == userId)
                    && db.Tables["Comments"].AsEnumerable().Any(p => (int)p.ItemArray[0] == currentCommentId))
                {
                    var row = db.Tables["UsersComments"].LoadDataRow(new object[]
                    {
                        userId,
                        currentCommentId
                    }, false);
                    if (row != null)
                    {
                        dgvLikesComment.AllowUserToAddRows = true;
                        this.dgvLikesComment.SelectionChanged -= dgvLikesComment_SelectionChangedAfterAddedNewRow;
                        UpdateDataSources();
                    }
                }
                else
                {
                    dgvLikesComment.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPhotoLikes_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.dgvPhotoLikes.SelectionChanged += dgvPhotoLikes_SelectionAfterAddedNewRowChanged;
        }

        private void dgvPhotoLikes_SelectionAfterAddedNewRowChanged(object sender, EventArgs e)
        {
            try
            {
                var newRow = dgvPhotoLikes.Rows[dgvPhotoLikes.RowCount - 2];
                int userId;
                if (Int32.TryParse(newRow.Cells[0].Value.ToString(), out userId)
                    && db.Tables["Users"].AsEnumerable().Any(u => (int)u.ItemArray[0] == userId)
                    && db.Tables["Photos"].AsEnumerable().Any(p => (int)p.ItemArray[0] == currentPhotoId))
                {
                    var row = db.Tables["UsersPhotos"].LoadDataRow(new object[]
                    {
                        userId,
                        currentPhotoId
                    }, false);
                    if (row != null)
                    {
                        dgvPhotoLikes.AllowUserToAddRows = true;
                        this.dgvPhotoLikes.SelectionChanged -= dgvPhotoLikes_SelectionAfterAddedNewRowChanged;
                        UpdateDataSources();
                    }
                }
                else
                {
                    dgvPhotoLikes.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Queries

        private DataTable ViewUsers()
        {
            DataTable dataTable = new DataTable("Users");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Name", typeof(String)),
                new DataColumn("Likes On Photos", typeof(Int32)),
                new DataColumn("Likes On Comments", typeof(Int32))
            });

            var rows = from user in db.Tables["Users"].AsEnumerable()
                       orderby user.Field<String>("Name")
                       select dataTable.LoadDataRow(new object[]
                       {
                            user.Field<String>("Name"),
                            user.GetChildRows("Users_Photos").Sum(r => r.GetChildRows("UsersPhotos_Photos").Count()),
                            user.GetChildRows("Users_Comments").Sum(r => r.GetChildRows("UsersComments_Comments").Count())
                       }, false);
            return (rows.Any()) ? rows.CopyToDataTable() : dataTable;
        }

        private DataTable ViewPhotoTable()
        {
            DataTable dataTable = new DataTable("Photos");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("AuthorId", typeof(Int32)),
                new DataColumn("Author", typeof(String)),
                new DataColumn("Id", typeof(Int32)),
                new DataColumn("Photo", typeof(String)),
                new DataColumn("Likes", typeof(Int32)),
                new DataColumn("Comments", typeof(Int32))
            });

            var rows = from photo in db.Tables["Photos"].AsEnumerable()                        
                        orderby photo.GetParentRow("Users_Photos").Field<String>("Name")
                        select dataTable.LoadDataRow(new object[]
                        {
                            photo.GetParentRow("Users_Photos").Field<Int32>("Id"),
                            photo.GetParentRow("Users_Photos").Field<string>("Name"),
                            photo.Field<Int32>("Id"),
                            photo.Field<string>("Name"),
                            photo.GetChildRows(db.Relations["UsersPhotos_Photos"]).Count(),
                            photo.GetChildRows(db.Relations["Photos_Comments"]).Count()
                        }, false);
            
            return (rows.Any()) ? rows.CopyToDataTable() : dataTable;
        }

        private DataTable ViewPeopleWhoLikesPhoto(int photoId)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(Int32)),
                new DataColumn("User", typeof(String))
            });
            var rows = from user in db.Tables["Users"].AsEnumerable()
                       join likes in db.Tables["UsersPhotos"].AsEnumerable()
                       on user.Field<Int32>("Id") equals likes.Field<Int32>("UserId")
                       where likes.Field<Int32>("PhotoId") == photoId
                       orderby user.Field<string>("Name")
                       select dataTable.LoadDataRow(new object[]
                       {
                           user.Field<Int32>("Id"),
                           user.Field<string>("Name")
                       },
                   false);

            return (rows.Any()) ? rows.CopyToDataTable() : dataTable;
        }

        private DataTable ViewCommentsToPhoto(int id)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(Int32)),
                new DataColumn("Comment", typeof(String)),
                new DataColumn("UserId", typeof(Int32)),
                new DataColumn("User", typeof(String)),
                new DataColumn("Likes", typeof(String))
            });
            var rows = from user in db.Tables["Users"].AsEnumerable()
                       join comment in db.Tables["Comments"].AsEnumerable()
                       on user.Field<Int32>("Id") equals comment.Field<Int32>("UserId")
                       where comment.Field<Int32>("PhotoId") == id
                       orderby user.Field<string>("Name")
                       select dataTable.LoadDataRow(new object[] 
                       {
                       comment.Field<Int32>("Id"),
                       comment.Field<string>("Content"),
                       user.Field<Int32>("Id"),
                       user.Field<string>("Name"),
                       comment.GetChildRows(db.Relations["UsersComments_Comments"]).Count()
                   }, false);

            return (rows.Any()) ? rows.CopyToDataTable() : dataTable;
        }

        private DataTable ViewPeopleWhoLikesComment(int commentId)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(Int32)),
                new DataColumn("User", typeof(String))
            });
            var rows = from user in db.Tables["Users"].AsEnumerable()
                       join likes in db.Tables["UsersComments"].AsEnumerable()
                       on user.Field<Int32>("Id") equals likes.Field<Int32>("UserId")
                       where likes.Field<Int32>("CommentId") == commentId
                       orderby user.Field<string>("Name")
                       select dataTable.LoadDataRow(new object[]
                       {
                       user.Field<Int32>("Id"),
                       user.Field<string>("Name")
                   }, false);

            return (rows.Any()) ? rows.CopyToDataTable() : dataTable;
        }
        #endregion
        
    }
}
