﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DelightDinner.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HostId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount_Amount = table.Column<decimal>(type: "decimal(5,4)", nullable: false),
                    Amount_Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dinners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    MaxGuests = table.Column<int>(type: "int", nullable: false),
                    Price_Amount = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Price_Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HostId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Latitude = table.Column<float>(type: "real", nullable: false),
                    Location_Longtitute = table.Column<float>(type: "real", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hosts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageRating_Value = table.Column<double>(type: "float", nullable: false),
                    AverageRating_NumRatings = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating_Value = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    HostId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuReviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AverageRating_Value = table.Column<double>(type: "float", nullable: false),
                    AverageRating_NumRatings = table.Column<int>(type: "int", nullable: false),
                    HostId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestCount = table.Column<long>(type: "bigint", nullable: false),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.DinnerId, x.Id });
                    table.ForeignKey(
                        name: "FK_Reservations_Dinners_DinnerId",
                        column: x => x.DinnerId,
                        principalTable: "Dinners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestBillIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestBillIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestBillIds_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestMenuReviewIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestMenuReviewIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestMenuReviewIds_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestPastDinnersIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestPastDinnersIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestPastDinnersIds_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestPendingDinnersIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestPendingDinnersIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestPendingDinnersIds_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestRatings",
                columns: table => new
                {
                    GuestRatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HostId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating_Value = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestRatings", x => new { x.GuestRatingId, x.GuestId });
                    table.ForeignKey(
                        name: "FK_GuestRatings_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestUpcommingDinnersIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestUpcommingDinnersIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestUpcommingDinnersIds_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HostDinnerIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HostDinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostDinnerIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostDinnerIds_Hosts_HostId",
                        column: x => x.HostId,
                        principalTable: "Hosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HostMenuIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HostMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostMenuIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostMenuIds_Hosts_HostId",
                        column: x => x.HostId,
                        principalTable: "Hosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuDinnerIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuDinnerIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuDinnerIds_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuReviewsIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuReviewsIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuReviewsIds_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuSections",
                columns: table => new
                {
                    MenuSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuSections", x => new { x.MenuSectionId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_MenuSections_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => new { x.MenuItemId, x.MenuSectionId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuSections_MenuSectionId_MenuId",
                        columns: x => new { x.MenuSectionId, x.MenuId },
                        principalTable: "MenuSections",
                        principalColumns: new[] { "MenuSectionId", "MenuId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuestBillIds_GuestId",
                table: "GuestBillIds",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestMenuReviewIds_GuestId",
                table: "GuestMenuReviewIds",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestPastDinnersIds_GuestId",
                table: "GuestPastDinnersIds",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestPendingDinnersIds_GuestId",
                table: "GuestPendingDinnersIds",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestRatings_GuestId",
                table: "GuestRatings",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestUpcommingDinnersIds_GuestId",
                table: "GuestUpcommingDinnersIds",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_HostDinnerIds_HostId",
                table: "HostDinnerIds",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_HostMenuIds_HostId",
                table: "HostMenuIds",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDinnerIds_MenuId",
                table: "MenuDinnerIds",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuSectionId_MenuId",
                table: "MenuItems",
                columns: new[] { "MenuSectionId", "MenuId" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuReviewsIds_MenuId",
                table: "MenuReviewsIds",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuSections_MenuId",
                table: "MenuSections",
                column: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "GuestBillIds");

            migrationBuilder.DropTable(
                name: "GuestMenuReviewIds");

            migrationBuilder.DropTable(
                name: "GuestPastDinnersIds");

            migrationBuilder.DropTable(
                name: "GuestPendingDinnersIds");

            migrationBuilder.DropTable(
                name: "GuestRatings");

            migrationBuilder.DropTable(
                name: "GuestUpcommingDinnersIds");

            migrationBuilder.DropTable(
                name: "HostDinnerIds");

            migrationBuilder.DropTable(
                name: "HostMenuIds");

            migrationBuilder.DropTable(
                name: "MenuDinnerIds");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "MenuReviews");

            migrationBuilder.DropTable(
                name: "MenuReviewsIds");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Hosts");

            migrationBuilder.DropTable(
                name: "MenuSections");

            migrationBuilder.DropTable(
                name: "Dinners");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
