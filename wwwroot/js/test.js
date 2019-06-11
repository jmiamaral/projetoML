$(document).ready(function () {
    $("#state-target").on("change", function () {
      $list = $("#city-target");
      $.ajax({
          url: "/getCities",
          type: "GET",
          data: { id: $("#state-target").val() }, //id of the state which is used to extract cities
          traditional: true,
          success: function (result) {
              $list.empty();
              $.each(result, function (i, item) {
                  $list.append('<option value="' + item["CityId"] + '"> ' + item["Name"] + ' </option>');
              });
          },
          error: function () {
              alert("Something went wrong call the police");
          }
      });
    });
  });