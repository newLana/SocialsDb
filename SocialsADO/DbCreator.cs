using System;
using System.Data;

namespace SocialsADO
{
    public class DbCreator
    {
        public DataSet SocialsDb { get; set; }

        public DbCreator()
        {
            SocialsDb = CreateDataBase();
            FillDataBase();
        }

        private void FillDataBase()
        {
            if (SocialsDb != null)
            {
                SocialsDb.Tables["Users"].Rows.Add(null, "John Doe");
                SocialsDb.Tables["Users"].Rows.Add(null, "Will Smith");
                SocialsDb.Tables["Users"].Rows.Add(null, "Charlize Theron");
                SocialsDb.Tables["Users"].Rows.Add(null, "Tom Hardy");
                SocialsDb.Tables["Users"].Rows.Add(null, "Scarlett Johansson");
                SocialsDb.Tables["Users"].Rows.Add(null, "Julia Roberts");
                SocialsDb.Tables["Users"].Rows.Add(null, "Colin Farrell");
                SocialsDb.Tables["Users"].Rows.Add(null, "Tom Cruise");
                SocialsDb.Tables["Users"].Rows.Add(null, "Leonardo DiCaprio");
                SocialsDb.Tables["Users"].Rows.Add(null, "Kate Hudson");
                SocialsDb.Tables["Users"].Rows.Add(null, "Kurt Russell");
                SocialsDb.Tables["Users"].Rows.Add(null, "Kate Winslet");
                SocialsDb.Tables["Users"].Rows.Add(null, "Dakota Johnson");


                SocialsDb.Tables["Photos"].Rows.Add(null, "Who am I?", 1);
                SocialsDb.Tables["Photos"].Rows.Add(null, "One good day", 2);
                SocialsDb.Tables["Photos"].Rows.Add(null, "My new role", 3);
                SocialsDb.Tables["Photos"].Rows.Add(null, "Coffee", 2);
                SocialsDb.Tables["Photos"].Rows.Add(null, "Hollywood", 4);
                SocialsDb.Tables["Photos"].Rows.Add(null, "My first oscar! Yeah!", 9);
                SocialsDb.Tables["Photos"].Rows.Add(null, "Finally he gets an oscar.", 12);
                SocialsDb.Tables["Photos"].Rows.Add(null, "My broken leg", 8);
                SocialsDb.Tables["Photos"].Rows.Add(null, "With my stepdaughter", 11);
                SocialsDb.Tables["Photos"].Rows.Add(null, "With my stepfather", 10);
                SocialsDb.Tables["Photos"].Rows.Add(null, "St.Patric`s Day in my homeland.", 7);
                SocialsDb.Tables["Photos"].Rows.Add(null, "I need beer", 7);
                SocialsDb.Tables["Photos"].Rows.Add(null, "Venom - because of my son.", 4);
                SocialsDb.Tables["Photos"].Rows.Add(null, "Autumn is ginger`s time", 6);
                SocialsDb.Tables["Photos"].Rows.Add(null, "Fifty shades of autumn", 13);

                SocialsDb.Tables["Comments"].Rows.Add(null, "Wins the oscar. Talks about climate change, good guy Leo.", 6, 6);
                SocialsDb.Tables["Comments"].Rows.Add(null, "This made me feel warm. congrats Leo!﻿.", 12, 6);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Yeah! I am a hero!", 9, 7);
                SocialsDb.Tables["Comments"].Rows.Add(null, "They are Hollywood Undead actually, but you were close *LOL*", 8, 5);
                SocialsDb.Tables["Comments"].Rows.Add(null, "You are truly undead *LOL*. Get well! Our world is in denger! *WINK*", 4, 8);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Unusual role. But you`re rock!", 5, 13);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Oh! We are so cuuute", 10, 9);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Oh! We are so cuuute", 11, 10);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Is boring.", 2, 9);
                SocialsDb.Tables["Comments"].Rows.Add(null, "So many green. And you`re so green - are you feel fine?", 12, 12);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Yeah, bro. I need its too.", 9, 12);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Shut up. You have vacation, so lets drink beer!", 7, 8);
                SocialsDb.Tables["Comments"].Rows.Add(null, "Yes! We know - you`re ginger, so what? Boooring..", 2, 14);

                SocialsDb.Tables["UsersPhotos"].Rows.Add(12, 7);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(1, 12);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(9, 12);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(6, 12);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(6, 7);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(8, 7);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(13, 4);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(10, 10);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(11, 11);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(4, 13);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(13, 13);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(5, 14);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(7, 9);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(9, 8);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(5, 13);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(11, 13);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(3, 13);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(13, 15);
                SocialsDb.Tables["UsersPhotos"].Rows.Add(3, 15);

                SocialsDb.Tables["UsersComments"].Rows.Add(9, 1);
                SocialsDb.Tables["UsersComments"].Rows.Add(9, 2);
                SocialsDb.Tables["UsersComments"].Rows.Add(12, 13);
                SocialsDb.Tables["UsersComments"].Rows.Add(12, 3);
                SocialsDb.Tables["UsersComments"].Rows.Add(8, 3);
                SocialsDb.Tables["UsersComments"].Rows.Add(4, 4);
                SocialsDb.Tables["UsersComments"].Rows.Add(8, 5);
                SocialsDb.Tables["UsersComments"].Rows.Add(4, 6);
                SocialsDb.Tables["UsersComments"].Rows.Add(11, 7);
                SocialsDb.Tables["UsersComments"].Rows.Add(10, 8);
                SocialsDb.Tables["UsersComments"].Rows.Add(5, 9);
                SocialsDb.Tables["UsersComments"].Rows.Add(7, 10);
                SocialsDb.Tables["UsersComments"].Rows.Add(7, 11);
                SocialsDb.Tables["UsersComments"].Rows.Add(8, 12);
                SocialsDb.Tables["UsersComments"].Rows.Add(2, 13);
                SocialsDb.Tables["UsersComments"].Rows.Add(9, 12);
                SocialsDb.Tables["UsersComments"].Rows.Add(1, 12);
                SocialsDb.Tables["UsersComments"].Rows.Add(8, 10);
            }
        }

        private DataSet CreateDataBase()
        {
            var db = new DataSet("SocialsDb"); //create db

            //add tables to db
            db.Tables.AddRange(new DataTable[]
            {
                new DataTable("Users"),
                new DataTable("Photos"),
                new DataTable("Comments"),
                new DataTable("UsersPhotos"),
                new DataTable("UsersComments")
            });

            // add columns to [dbo].[Users] 
            db.Tables["Users"].Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(Int32))
                {
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    Unique = true
                },
                new DataColumn("Name", typeof(String))
                {
                    MaxLength = 50,
                    AllowDBNull = false
                }
            });



            // add columns to [dbo].[Photos] 
            db.Tables["Photos"].Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(Int32))
                {
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementStep = 1,
                    AutoIncrementSeed = 1,
                    Unique = true
                },
                new DataColumn("Name", typeof(String))
                {
                    MaxLength = 50,
                    AllowDBNull = false
                },
                new DataColumn("UserId", typeof(Int32))
                {
                    AllowDBNull = false
                }
            });

            // add columns to [dbo].[Comments] 
            db.Tables["Comments"].Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(Int32))
                {
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    Unique = true
                },
                new DataColumn("Content", typeof(String))
                {
                    AllowDBNull = false
                },
                new DataColumn("UserId", typeof(Int32))
                {
                    AllowDBNull = false
                },
                new DataColumn("PhotoId", typeof(Int32))
                {
                    AllowDBNull = false
                }
            });

            // add columns to [dbo].[UsersPhotos] 
            db.Tables["UsersPhotos"].Columns.AddRange(new DataColumn[]
            {
                new DataColumn("UserId", typeof(Int32))
                {
                    AllowDBNull = false
                },
                new DataColumn("PhotoId", typeof(Int32))
                {
                    AllowDBNull = false
                }
            });

            // add columns to [dbo].[UsersComments] 
            db.Tables["UsersComments"].Columns.AddRange(new DataColumn[]
            {
                new DataColumn("UserId", typeof(Int32))
                {
                    AllowDBNull = false
                },
                new DataColumn("CommentId", typeof(Int32))
                {
                    AllowDBNull = false
                }
            });

            //add PK constraints
            for (int i = 0; i < 3; i++)
            {
                db.Tables[i].PrimaryKey = new DataColumn[] { db.Tables[i].Columns["Id"] };
            }

            db.Tables["UsersPhotos"].PrimaryKey = new DataColumn[]
            {
                db.Tables["UsersPhotos"].Columns["UserId"],
                db.Tables["UsersPhotos"].Columns["PhotoId"]
            };

            db.Tables["UsersComments"].PrimaryKey = new DataColumn[]
            {
                db.Tables["UsersComments"].Columns["UserId"],
                db.Tables["UsersComments"].Columns["CommentId"]
            };

            //add FK constraints
            db.Tables["Photos"].Constraints.Add(new ForeignKeyConstraint("fk_users_photos",
                db.Tables["Users"].Columns["Id"], db.Tables["Photos"].Columns["UserId"])
            {
                DeleteRule = Rule.Cascade,
                UpdateRule = Rule.Cascade
            });

            db.Tables["Comments"].Constraints.Add(new ForeignKeyConstraint("fk_users_comments",
                db.Tables["Users"].Columns["Id"], db.Tables["Comments"].Columns["UserId"])
            {
                DeleteRule = Rule.Cascade,
                UpdateRule = Rule.Cascade
            });

            db.Tables["Comments"].Constraints.Add(new ForeignKeyConstraint("fk_photos_comments",
                db.Tables["Photos"].Columns["Id"], db.Tables["Comments"].Columns["PhotoId"])
            {
                DeleteRule = Rule.Cascade,
                UpdateRule = Rule.Cascade
            });

            db.Tables["UsersPhotos"].Constraints.Add(new ForeignKeyConstraint("fk_users_usersphotos",
                db.Tables["Users"].Columns["Id"], db.Tables["UsersPhotos"].Columns["UserId"])
            {
                DeleteRule = Rule.Cascade,
                UpdateRule = Rule.Cascade
            });

            db.Tables["UsersPhotos"].Constraints.Add(new ForeignKeyConstraint("fk_photos_usersphotos",
                db.Tables["Photos"].Columns["Id"], db.Tables["UsersPhotos"].Columns["PhotoId"])
            {
                DeleteRule = Rule.Cascade,
                UpdateRule = Rule.Cascade
            });

            db.Tables["UsersComments"].Constraints.Add(new ForeignKeyConstraint("fk_users_userscomments",
                db.Tables["Users"].Columns["Id"], db.Tables["UsersComments"].Columns["UserId"])
            {
                DeleteRule = Rule.Cascade,
                UpdateRule = Rule.Cascade
            });

            db.Tables["UsersComments"].Constraints.Add(new ForeignKeyConstraint("fk_comments_userscomments",
                db.Tables["Comments"].Columns["Id"], db.Tables["UsersComments"].Columns["CommentId"])
            {
                DeleteRule = Rule.Cascade,
                UpdateRule = Rule.Cascade
            });

            db.Relations.Add("UsersPhotos_Photos", db.Tables["Photos"].Columns["Id"], db.Tables["UsersPhotos"].Columns["PhotoId"]);
            db.Relations.Add("UsersComments_Comments", db.Tables["Comments"].Columns["Id"], db.Tables["UsersComments"].Columns["CommentId"]);
            db.Relations.Add("Users_Photos", db.Tables["Users"].Columns["Id"], db.Tables["Photos"].Columns["UserId"]);
            db.Relations.Add("Photos_Comments", db.Tables["Photos"].Columns["Id"], db.Tables["Comments"].Columns["PhotoId"]);
            db.Relations.Add("Users_Comments", db.Tables["Users"].Columns["Id"], db.Tables["Comments"].Columns["UserId"]);

            db.EnforceConstraints = true;

            return db;
        }
    }
}

