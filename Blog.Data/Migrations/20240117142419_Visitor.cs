using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("651164a5-2bf1-4dad-93be-06f3b1324b9f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a48f3769-22c2-4354-8f3c-f4ea0eff2658"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3dfee43f-131c-40f3-83b4-f782e768a349"), new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(8060), null, null, new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"), false, null, null, "resim", new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"), 15 },
                    { new Guid("ce16ea73-4333-4c99-9538-16997c3e4bec"), new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(8053), null, null, new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"), 20 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b9de5b7-9c7b-47be-83f7-a3bc6c9261fb"),
                column: "ConcurrencyStamp",
                value: "36b994a3-edd9-4088-be19-61474d8fc796");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("880a75ab-3fa5-47fc-a721-5a5e5ee257eb"),
                column: "ConcurrencyStamp",
                value: "a6db749c-d87d-47e0-b703-2ee954fdc390");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c24cfeb2-4715-4185-883d-01a4995c139b"),
                column: "ConcurrencyStamp",
                value: "718d3b80-a366-42f8-a14a-7d41b93c51d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea539547-13e9-44bb-bbff-1b2fd093cf12", "AQAAAAEAACcQAAAAEOKJw7qKlKDX5EjRqc5tbtCqfuQOiqh0DUoYJ5VMT4BLRnsxoes9tMjiFWSHerM21Q==", "c638a739-4ac8-4a72-b63b-77e4982e6832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ccdea36-1b35-4544-8bb1-424805ac9794", "AQAAAAEAACcQAAAAEF4HfytgD5IHFK05lSBZkNCOP2gqCTm9ISa0xx95rqYhvDEuw6hAOZaQopHQWSE2OQ==", "4926f5a7-3307-4813-862e-2acb1b493746" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3dfee43f-131c-40f3-83b4-f782e768a349"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ce16ea73-4333-4c99-9538-16997c3e4bec"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("651164a5-2bf1-4dad-93be-06f3b1324b9f"), new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2023, 10, 24, 13, 30, 52, 777, DateTimeKind.Local).AddTicks(8324), null, null, new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"), 20 },
                    { new Guid("a48f3769-22c2-4354-8f3c-f4ea0eff2658"), new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2023, 10, 24, 13, 30, 52, 777, DateTimeKind.Local).AddTicks(8330), null, null, new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"), false, null, null, "resim", new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b9de5b7-9c7b-47be-83f7-a3bc6c9261fb"),
                column: "ConcurrencyStamp",
                value: "ed29d0eb-95dd-4156-a5b0-38820191dcad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("880a75ab-3fa5-47fc-a721-5a5e5ee257eb"),
                column: "ConcurrencyStamp",
                value: "c0ef65a5-5a8e-4c5b-947c-3843cb9818f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c24cfeb2-4715-4185-883d-01a4995c139b"),
                column: "ConcurrencyStamp",
                value: "3c9e5cfc-b000-423e-ad8d-fc09228e7fcd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abebad25-0dbc-4bfc-95ad-5f49a0cd61cd", "AQAAAAEAACcQAAAAEMARjfAk+CruglsHrV1IqmVVyp6IGgheGVjYZwBYRizQcPtxfvBEiYaWc2rxxBngqA==", "c7114cc2-4464-4e58-8645-6964980c7e24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "738095bd-1247-4982-8912-739a41ba6742", "AQAAAAEAACcQAAAAEC/+ig385W+8SDJ38EojEJpidUah/b24G5sMHUqq1DLTAE4BZVNAooxmxNL4z8pF9g==", "aca4ae40-3db8-4176-b457-95b07713d1bb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 30, 52, 777, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 30, 52, 777, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 30, 52, 777, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 30, 52, 777, DateTimeKind.Local).AddTicks(8549));
        }
    }
}
