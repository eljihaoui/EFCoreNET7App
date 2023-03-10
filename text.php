<?php
/*
* SOURCE: https://hoolite.be/tips-tricks/create-your-own-custom-related-posts-for-wordpress-no-plugin/.
*/
$related = new WP_Query(
	array(
		'post_type'      => 'tutorials', // YOUR CPT SLUG.
		'category__in'   => wp_get_post_categories( $post->ID ),
		'posts_per_page' => 3,
		'post__not_in'   => array( $post->ID ),
	)
);

if ( $related->have_posts() ) : ?>
	<h3><?php esc_html_e( 'You might like this too!', 'hoolite' ); ?></h3>
	<ul class="related-posts">
		<?php
		while ( $related->have_posts() ) :
			$related->the_post();
			?>
			<a href="<?php the_permalink(); ?>" title="<?php the_title(); ?>">
				<li>
					<?php if ( has_post_thumbnail( $post->ID ) ) { ?>
						<div class="related-post-text-inner">
								<h4><?php the_title(); ?></h4>
						</div>
				</li>
			</a>
			<?php
			endwhile;
			wp_reset_postdata();
		?>
	</ul>
<?php endif; ?>