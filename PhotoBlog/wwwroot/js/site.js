// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
dayjs.extend(window.dayjs_plugin_relativeTime);

/*
 * data-post-time attribute sahibi tum elementleri gez 
 * data-post-time attribute-u icinde yer alan degerleri eline al 
 * dayjs().to(dayjs(...)) metodu icine sok ve ciktisini al
 * ciktiyi elimize 1.adimda aldigimiz elementin metnine koy 
 * 
 */

$("[data-post-time]").each(function () {

    let isoTime = $(this).data("post-time");
    let relativeTime = dayjs().to(dayjs(isoTime));
    $(this).text(relativeTime);
});
 